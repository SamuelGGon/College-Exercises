import struct
import os
from time import sleep

def analisar_rofs(caminho_arquivo):
    with open(caminho_arquivo, "rb") as f:
        # 1. Lendo os primeiros 4 bytes (sua hipótese do contador)
        while(True):
            ponteiro = f.tell()
            dados_iniciais = f.read(16)
            if not dados_iniciais:
                break
            sleep(2)
            print(f" Ponteiro => {ponteiro} \n {dados_iniciais}")
        
        print()

caminho = "I:\\RE3 Nemesis\\Rofs8.dat"


analisar_rofs(caminho)
# Substitua pelo caminho real do seu Rofs8.dat
# analisar_rofs("S:/RE3/Rofs8.dat")