import os

def encontrar_letras(ficheiro_txt, nome_versao):
    if not os.path.exists(ficheiro_txt):
        print(f"Erro: Ficheiro {ficheiro_txt} não encontrado.")
        return

    print(f"\nÀ procura das letras no ficheiro {nome_versao}...")
    print("-" * 60)
    
    contador = 0
    with open(ficheiro_txt, 'r', encoding='utf-8') as f:
        for linha in f:
            if "RGB:(" in linha:
                # Extrair os valores RGB do texto
                try:
                    partes_rgb = linha.split("RGB:(")[1].split(")")[0]
                    r, g, b = [int(x.strip()) for x in partes_rgb.split(',')]
                    
                    # Se a cor for clara (acima de 100), significa que atingiu a letra
                    if r > 100 and g > 100 and b > 100:
                        print(linha.strip())
                        contador += 1
                        
                        # Mostra apenas os primeiros 7 píxeis da letra para não encher o ecrã
                       
                except:
                    pass
    print("-" * 60)

# ==========================================
# CONFIGURAÇÃO: NOME DOS SEUS FICHEIROS TXT
# ==========================================
txt_original = 'C:\\Users\\samue\\OneDrive\\Desktop\\MAPA_WARNU_ORIGINAL.txt'
txt_modificado = 'C:\\Users\\samue\\OneDrive\\Desktop\\MAPA_WARNU_MOD.txt'

encontrar_letras(txt_original, "ORIGINAL DA CAPCOM")
encontrar_letras(txt_modificado, "MODIFICADO (A SUA TRADUÇÃO)")