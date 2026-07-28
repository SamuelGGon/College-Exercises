from pathlib import Path
from time import sleep
import  requests

from bs4 import BeautifulSoup

entrada = True

cdromance_url = "https://cdromance.org/"

pastaSalvandoArquivo = Path("I:/Jogos Emulador/PS1")

resposta =  requests.get(cdromance_url)

menuDePlataformas = "menu-item-173032"
sonyId = "menu-item-252038"
ps1 = "menu-item-78404"
classe1 = "game-container"
classe2 = "bottom-section"
classeDasPaginas = "page-numbers"
pedirLinkDeDownload = "https://cdromance.org/wp-content/plugins/cdr-main/public/ajax.php"
url_praSejuntar = ""
contadorDePagina = 2
pagina = "page/" + str(contadorDePagina) + "/"
paginaTotal = ""

sopa = BeautifulSoup(resposta.text, "html.parser")

menuPlataformaElemento = sopa.find(id = menuDePlataformas)
gavetaSony = menuPlataformaElemento.find(id = sonyId) 
psOne = gavetaSony.find(id = ps1)

while(entrada):
    
    for pai in psOne.find_all("a"):

        if not url_praSejuntar.count(pai["href"].lstrip('/')):
            
            url_praSejuntar = pai["href"].lstrip('/') #psx-iso/
            novaReposta = requests.get(cdromance_url + url_praSejuntar)
            novaSopa = BeautifulSoup(novaReposta.text,  "html.parser")
            jogosEncontrados =  novaSopa.find_all("div", class_ = classe1)
            VePaginasTotais = novaSopa.find_all("a", class_ = classeDasPaginas)
            paginaTotal = str(VePaginasTotais.pop(1)["href"].split(url_praSejuntar)[1])

        else:

            novaReposta = requests.get(cdromance_url + url_praSejuntar)
            novaSopa = BeautifulSoup(novaReposta.text,  "html.parser")
            jogosEncontrados =  novaSopa.find_all("div", class_ = classe1)
        

        print(cdromance_url + url_praSejuntar)

        linkDeComparacao = ""

        for jogosLista in jogosEncontrados:


            if jogosLista.find("div", class_ = "region").get("title") == "Region USA" and not jogosLista.find("span", class_ = "bannertag hack"):
                print(jogosLista.find("div", class_ = "region").get("title"))
                nomeDoJogo = jogosLista.find("div", class_ = "game-title").text
                

                for jogo in jogosLista.find_all("a"):

                    if jogo.get("title") == "comments":
                        continue
                    else:
                        linkDosJogos = jogo["href"]
                        acessandoLink = BeautifulSoup(requests.get(linkDosJogos).text, "html.parser")

                        if acessandoLink.find(id = "forumBtn"):
                            
                            print("é forum ")
                        else:

                            print("Não é forum")

                            down = acessandoLink.find("div", id = "download")

                            botao = down.find("div", id = "acf-content-wrapper")

                            idDoJogo = botao.get("data-id")

                            headsPraPegarOLinkDeDownload = {"X-Requested-With": "XMLHttpRequest"}

                            headsPraFazeroDowload = {
                                "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/144.0.0.0 Safari/537.36",
                                "Referer": linkDosJogos
                                }
                            
                            fazendoRequicao = requests.post(pedirLinkDeDownload, {"post_id": idDoJogo}, headers = headsPraPegarOLinkDeDownload)

                            textoDoHTML = fazendoRequicao.text

                            sopinha = BeautifulSoup(textoDoHTML, "html.parser")

                            linkDeDownload = sopinha.find("a", id = "dl-btn-0")["href"]

                            download = requests.get(linkDeDownload,headers = headsPraFazeroDowload ,stream = True)

                            print(f"LINK DOWN {linkDeDownload}")
                            print(download.headers)

                            nomeDoArquivo = download.headers.get("Content-Disposition").split("filename=")[1].split(";")[0].replace('"', '')
                            #print(download.headers)
                            caminhoFinal = pastaSalvandoArquivo / nomeDoArquivo


                            tamanhoDoJogo = int(download.headers.get("Content-Length"))

                            
                            if str(linkDeDownload) != linkDeComparacao:
                                
                                print(f"Baixando {nomeDoArquivo}")

                                #with open(caminhoFinal, "wb") as arquivo:
                                    #total = 0
                                    #for parte in download.iter_content(chunk_size=8192):
                                        #if parte:
                                            #arquivo.write(parte)
                                            #total += (len(parte) / tamanhoDoJogo) * 100

                                            #print(f"Baixados: {total:.2f}%",end= "\r")

                                print("Download Feito!")
                                linkDeComparacao = str(linkDeDownload)
                            print(f"LINK DOWN {linkDeDownload}")
                            print(f"LINK COMPARA {linkDeComparacao}")

                            #Coisa pra corrigir, está fazendo download do mesmo arquivo duas vezes.
        
                            #Fazer Generico para todas ROMs
    if pagina != paginaTotal:
        url_praSejuntar += pagina
        contadorDePagina += 1
    else:
        entrada = False

       
    
                    

                        
                        



                       



            

                
            
                               











    


