import os
import requests

from requests import Response
from pathlib import Path
from bs4 import BeautifulSoup
from resilience import retry

cdromance_url = "https://cdromance.org"
pedirLinkDeDownload = "https://cdromance.org/wp-content/plugins/cdr-main/public/ajax.php"
DOWNLOAD_CHUNK_SIZE = int(os.environ.get("DOWNLOAD_CHUNK_SIZE", "8192"))

amarelo = '\033[33m'
verde = '\033[32m'
bold = '\033[1m'
reset = '\033[0m'

listaGamesAtuais = []
quantidadeDeJogosDaLista = 0
porcento = 0

def get_all_platforms():
    platforms_url = f"{cdromance_url}/platforms"
    response = requests.get(platforms_url)

    soup = BeautifulSoup(response.text, "html.parser")
    platforms = []

    headers = soup.find("div", class_="entry-content").find_all("h3")
    for h3 in headers:
        anchors = h3.find_next_sibling("ul").find_all("a")

        for anchor in anchors:
            platform = anchor["href"].split("/")[-2]
            platforms.append(platform)

    return platforms

def platform_is_valid(platform: str) -> bool:
    platform_url = f"{cdromance_url}/{platform}"
    response = requests.get(platform_url)

    if response.status_code >= 500:
        raise Exception("CD Romance indisponível no momento")
    
    return response.status_code == 200

def download_roms_for_platform(platform: str, page: int=1, tags: list[str]=[], no_download = True) -> None:
    platform_page_url = f"{cdromance_url}/{platform}/page/{page}"
    response = requests.get(platform_page_url)

    if response.status_code != 200:
        return
    
    stuff(response, no_download)

    download_roms_for_platform(platform, page + 1, no_download = no_download)

def prepare_download(acessandoLink: BeautifulSoup) -> list[str]:

    listaDeLinks = []

    numDisco = 0

    down = acessandoLink.find("div", id = "download")

    botao = down.find("div", id = "acf-content-wrapper")

    idDoJogo = botao.get("data-id")

    headsPraPegarOLinkDeDownload = {"X-Requested-With": "XMLHttpRequest"}
    
    fazendoRequicao = requests.post(pedirLinkDeDownload, {"post_id": idDoJogo}, headers = headsPraPegarOLinkDeDownload)

    textoDoHTML = fazendoRequicao.text

    sopinha = BeautifulSoup(textoDoHTML, "html.parser")
    
    while True:

        if sopinha.find("a", id = f"dl-btn-{numDisco}") != None:

            listaDeLinks.append(sopinha.find("a", id = f"dl-btn-{numDisco}")["href"])
            numDisco += 1

        else:

            numDisco = 0
            break
    
    return listaDeLinks
    






def verificar_arquivos_existente(caminho_final: Path, tamanho_do_jogo: int) -> bool:
    existencia = caminho_final.exists()
    
    if not existencia:
        return False
    
    tamanho_do_jogo_local = caminho_final.stat().st_size

    return existencia and tamanho_do_jogo == tamanho_do_jogo_local

@retry
def download_rom(nome_jogo: str, lista_de_links_download: list, linkDosJogos: str) -> None:

    global quantidadeDeJogosDaLista
    global porcento

    for download_url in lista_de_links_download: 

        headsPraFazeroDowload = {
            "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/144.0.0.0 Safari/537.36",
            "Referer": linkDosJogos
        }
        game_file_metadata = requests.head(download_url, headers = headsPraFazeroDowload)
        pastaSalvandoArquivo = Path(os.environ.get("SAVE_DIR", default="I:/Jogos Emulador/PS1"))

        nomeDoArquivo = game_file_metadata.headers.get("Content-Disposition").split("filename=")[1].split(";")[0].replace('"', '')
        tamanhoDoJogo = int(game_file_metadata.headers.get("Content-Length"))
        caminhoFinal = pastaSalvandoArquivo / nomeDoArquivo

        if verificar_arquivos_existente(caminhoFinal, tamanhoDoJogo):
            print(f"    ┗━ {verde}{nome_jogo} - {bold}{100:.2f}% (já existente){reset}")

            if nome_jogo in listaGamesAtuais:
                quantidadeDeJogosDaLista += 1
            continue

        if porcento == 1:
            porcento = 0
            total_de_jogos = len(listaGamesAtuais)

            feito = quantidadeDeJogosDaLista

            faltam = total_de_jogos - feito
            
            if total_de_jogos > 0:
                porcento = (quantidadeDeJogosDaLista / total_de_jogos) * 100
                print()
                print(f"{bold}Progresso da coleção:{reset}")
                print(f"{verde}{feito}{reset} / {total_de_jogos} jogos")
                print(f"{amarelo}Faltam baixar: {faltam}{reset}")
                print(f"{bold}{porcento:.2f}% completo{reset}")
            else:
                print(f"{amarelo}Não foi possível calcular o progresso: lista de jogos vazia.{reset}")
        

        download = requests.get(download_url, headers=headsPraFazeroDowload, stream=True)
        total = 0
        with open(caminhoFinal, "wb") as arquivo:
            for parte in download.iter_content(chunk_size=DOWNLOAD_CHUNK_SIZE):
                if parte:
                    arquivo.write(parte)
                    total += (len(parte) / tamanhoDoJogo) * 100

                    print(f"    ┗━ {amarelo}{nome_jogo} - {bold}{total:.2f}% {reset}",end= "\r")
            print(f"    ┗━ {verde}{nome_jogo} - {bold}{total:.2f}% {reset}",end= "\n")
        
def stuff(response: Response, no_download) -> None:
    game_container_class = "game-container"
    
    novaSopa = BeautifulSoup(response.text,  "html.parser")
    jogosEncontrados =  novaSopa.find_all("div", class_ = game_container_class)

    for jogosLista in jogosEncontrados:

        if jogosLista.find("div", class_ = "region").get("title") == "Region USA" and not jogosLista.find("span", class_ = "bannertag hack"):
            nomeDoJogo = jogosLista.find("div", class_ = "game-title").text
            
            for jogoContainer in jogosLista.find_all("div", class_="bottom-section"):
                jogo = jogoContainer.find("a")
                
                if jogo.get("title") == "comments":
                    print(jogo.text)
                    continue
                
                linkDosJogos =  jogo["href"]
                acessandoLink = BeautifulSoup(requests.get(linkDosJogos).text, "html.parser")

                if acessandoLink.find(id = "forumBtn"):
                    continue
                
                if no_download:
                    VerJogosDisponiveisPraDownload = f"    ┗━ {amarelo}{nomeDoJogo}{reset}"
                    listaGamesAtuais.append(nomeDoJogo)
                    print(VerJogosDisponiveisPraDownload)
                    continue

                linkDeDownload = prepare_download(acessandoLink)
                download_rom(nomeDoJogo, linkDeDownload, linkDosJogos)
    