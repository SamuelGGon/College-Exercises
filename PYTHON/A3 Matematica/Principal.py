# ... (seus imports permanecem iguais)
import pandas as pd 
from time import sleep
import matplotlib.pyplot as mate
import numpy as np
import tkinter as TK
import tkinter.ttk as TTK
import tkinter.filedialog as TKFD
import tkinter.messagebox as TKMB
from pathlib import Path as PATH
import os

class interface(TK.Tk):
    def __init__(self):
        TK.Tk.__init__(self)
        self.title("Chronix")
        
        
        self.tempo = None
        self.num = None
        self.ys = None

        self.frame_main = TTK.Frame(self)
        self.frame_main.grid(row=0, column=0, padx=5, pady=5)
        
        
        TK.Button(self.frame_main, text="1. Carregar Dados", width=30, 
                  command=self.carregar_dados).grid(row=0, column=0, padx=5, pady=7)
        
        
        TK.Button(self.frame_main, text="2. Colocar Pontos no Gráfico", width=30, 
                  command=self.bt_primeiro_grafico).grid(row=1, column=0, padx=5, pady=7)
        
        TK.Button(self.frame_main, text="3. Fazer Interpolação", width=30, 
                  command=self.bt_colocar_pontos_no_gráfico).grid(row=2, column=0, padx=5, pady=7)

    def carregar_dados(self):

        caminho = TKFD.askopenfilename(title = "Selecione o arquivo CSV", filetypes = [("Arquivos CSV", "*.csv"), ("Todos os arquivos", "*.*")])
        if caminho:

            try:

                self.tempo, self.num = entradaArquivo(caminho)
                self.ys = pegarPolimofismo(self.num)
                TKMB.showinfo("Sucesso", "Dados carregados com sucesso!")
            except Exception as e:
                TKMB.showerror("Erro", f"Erro ao ler arquivo: {e}")

        else:
            print("Operação cancelada")


    def bt_primeiro_grafico(self):
        if self.num is None:
            TKMB.showwarning("Aviso", "Carregue os dados primeiro!")
            return
        
        for g, k in enumerate(self.num):
            mate.figure()
            mate.title(f"Dados originais - Coluna {g + 1}")
            fazerGrafico(self.tempo[0], k)

        mate.show()
    

    def bt_colocar_pontos_no_gráfico(self):
        if self.num is None:
            TKMB.showwarning("Aviso", "Carregue os dados primeiro!")
            return
        for j, (coluna_original, coluna_polinomio) in enumerate(zip(self.num, self.ys)):
            mate.figure()
            mate.title(f"Gráfico da Coluna {j + 1}")
            fazerGraficoPolimorfico(self.tempo[0], coluna_original, coluna_polinomio)
        mate.show()
       
def entradaArquivo(caminho : str):
    data = pd.read_csv(caminho, header = None)

    lista_numericas_de_tudo = []
    lista_de_datas_de_tudo = []

    for colunas in data.columns:
        
        coluna_atual_de_num = []
        coluna_atual_de_datas = []
        dado_util = False
        

        for linhas in data[colunas].values:
            
            if(pd.isna(linhas)):
                coluna_atual_de_num.append(np.nan)
                continue

            try:
                valor_sem_virgula = str(linhas).replace(",", ".")
                num = float(valor_sem_virgula)
                coluna_atual_de_num.append(num)
                
                dado_util = True
                
                #print(f"Se deus quiser é numero: {num}")

            except ValueError:
                try:

                    datas = pd.to_datetime(linhas, dayfirst = True)
                    coluna_atual_de_datas.append(datas)
                except:
                    coluna_atual_de_num.append(np.nan)
                    
                    pass

        if (dado_util):
            lista_numericas_de_tudo.append(coluna_atual_de_num)


        if (len(coluna_atual_de_datas) > 0):
            que_mais_repete = pd.Series(coluna_atual_de_datas)

            repeticao_max =  que_mais_repete.value_counts().max()

            porcento_repeticao = repeticao_max / len(que_mais_repete)

            if porcento_repeticao < 0.9:
        
                lista_de_datas_de_tudo.append(coluna_atual_de_datas)

    indice_eliminar = []

    for x in range(0, len(lista_de_datas_de_tudo)):
        for y in range(0, len(lista_de_datas_de_tudo[x])):

            if(pd.isna(lista_de_datas_de_tudo[x][y])):
                indice_eliminar.append(y)

    for g in range(0, len(lista_numericas_de_tudo)):
        for h in range(0, len(lista_numericas_de_tudo[g])):

            if(pd.isna(lista_numericas_de_tudo[g][h])):
                indice_eliminar.append(h)

    elementos_unicos = set(indice_eliminar)

    tirar_elemento = sorted(elementos_unicos, reverse = True)

    #o problema está aqui ao percorrer os indices
    print(len(lista_de_datas_de_tudo[0]))

    for i in tirar_elemento:
        for o in lista_numericas_de_tudo:
            o.pop(i)

        for p in lista_de_datas_de_tudo:
            p.pop(i)

    return lista_de_datas_de_tudo, lista_numericas_de_tudo

def fazerGrafico(lista1, lista2):

    mate.plot(lista1, lista2, color = 'blue', alpha = 0.5)

    mate.xlabel("coluna_atual_de_datas")
    #mate.title("Temperatura, coluna_atual_de_datas")
    

    mate.legend()
    #mate.show()

def verificadorDePolinomio(lista: list, x: float):
    #y = ax^2 + bx + c

    grau = len(lista) - 1
    y = 0
    
    for index in range(0, len(lista)):
        y += lista[index] * ((x ** (grau - index))) 
    
    
    return y
    
    # função de grau n, vai ser n coeficientes + 1

def pegarPolimofismo(lista_de_num : list):
    polis = []
    ys_para_a_polimorfismo = []

    for k in lista_de_num:
        
        calculo_dos_ys = np.polyfit(range(1, len(k)+ 1), k, 80)
        polis.append(calculo_dos_ys)



    contador = 0


    while(True):
        lista_dos_y = []

        for x in range(1, len(lista_de_num[contador]) + 1):
            ys = verificadorDePolinomio(polis[contador], x)
            lista_dos_y.append(ys)
        
        ys_para_a_polimorfismo.append(lista_dos_y)
        contador += 1

        if contador == len(polis):
            break 

    return ys_para_a_polimorfismo

def fazerGraficoPolimorfico(eixo_x: list, lista_num_original : list, lista_dos_ys):
    mate.plot(eixo_x, lista_num_original, color = 'blue', alpha = 0.5)
    mate.plot(eixo_x, lista_dos_ys, color = 'red')

    

    mate.legend()
    #mate.show() 
    


if __name__ == "__main__":
    app = interface()
    app.mainloop() 