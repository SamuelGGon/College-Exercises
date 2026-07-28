import subprocess
import os
import crawler 

from dotenv import load_dotenv
load_dotenv()

interacao = 0 
faz = False

tags = [ ]

def display_header():
    #subprocess.run("clear")

    print(
    ''' 
██████╗  █████╗ ██╗██╗  ██╗ █████╗ ███╗   ██╗██████╗  ██████╗     ██████╗  ██████╗ ███╗   ███╗███████╗
██╔══██╗██╔══██╗██║╚██╗██╔╝██╔══██╗████╗  ██║██╔══██╗██╔═══██╗    ██╔══██╗██╔═══██╗████╗ ████║██╔════╝
██████╔╝███████║██║ ╚███╔╝ ███████║██╔██╗ ██║██║  ██║██║   ██║    ██████╔╝██║   ██║██╔████╔██║███████╗
██╔══██╗██╔══██║██║ ██╔██╗ ██╔══██║██║╚██╗██║██║  ██║██║   ██║    ██╔══██╗██║   ██║██║╚██╔╝██║╚════██║
██████╔╝██║  ██║██║██╔╝ ██╗██║  ██║██║ ╚████║██████╔╝╚██████╔╝    ██║  ██║╚██████╔╝██║ ╚═╝ ██║███████║
╚═════╝ ╚═╝  ╚═╝╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═════╝  ╚═════╝     ╚═╝  ╚═╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝                                                                                                   
    '''
    )

if __name__ == "__main__":
    display_header()

    platforms = crawler.get_all_platforms()
    platforms = ["psx-iso"]

    if len(platforms) < 1:
        raise Exception("Nenhum console encontrado")

    for platform in platforms:
        print(f"▪ {platform}")

        if not crawler.platform_is_valid(platform):
            print(f"Roms para console '{platform}' não encontradas")
            continue
        
        crawler.quantidadeDeJogosDaLista = 0
        crawler.listaGamesAtuais.clear()
        
        crawler.download_roms_for_platform(platform, tags=tags, no_download = True)

        crawler.porcento = 1

        crawler.download_roms_for_platform(platform, tags=tags, no_download = False)

        

        


