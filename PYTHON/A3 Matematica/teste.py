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
        self.title("A3")
        self.frame_main = TTK.Frame(self)
        self.frame_main.grid(row=0, column=0, padx=5, pady=5, sticky=TK.W+TK.N+TK.S+TK.E)
        self.frame_control_main = TTK.Frame(self.frame_main)
        self.frame_control_main.grid(row=1, column=0, columnspan=2, padx=5, pady=5, sticky=TK.W+TK.N)
        # self._max_res = [1200, 900]
        # self.tittle("interface")
        global initialdir
        # self.read_arquivo()
        if not os.path.exists(initialdir):
            self.bt_open_folder()
            TKMB.showinfo("Info", "Escolha a pasta")
            return
        TK.Button(self.frame_control_main, text="Change Folder", width=15, command=self.bt_open_folder).grid(row=0, column=6, padx=5, pady=5)
        TK.Button(self.frame_control_main, text="Primeiro Grafico Temperatura", width =30, command= self.bt_primeiro_grafico).grid(row=2, column=6, padx=5, pady=7)
        TK.Button(self.frame_control_main, text="Segundo Grafico Temperatura", width =30, command= self.bt_segundo_grafico).grid(row=2, column=7, padx=5, pady=7)
        TK.Button(self.frame_control_main, text="Primeiro Grafico Umidade", width =30, command= self.bt_primeiro_grafico_umidade).grid(row=2, column=8, padx=5, pady=7)
        TK.Button(self.frame_control_main, text="Segundo Grafico Umidade", width =30, command= self.bt_segundo_grafico_umidade).grid(row=4, column=6, padx=5, pady=7)
        TK.Button(self.frame_control_main, text="Grafico Umidade sobre Temperatura", width =30, command= self.bt_grafico_umidade_sobre_temperatura).grid(row=4, column=7, padx=5, pady=7)
        TK.Button(self.frame_control_main, text="Grafico Razão Umidade Temperatura", width =30, command= self.bt_grafico_razão_umidade_temperatura).grid(row=4, column=8, padx=5, pady=7)
        TK.Button(self.frame_control_main, text="Grafico Erro Relativo Temperatura", width =30, command= self.bt_grafico_erro_relativo_temperatura).grid(row=6, column=6, padx=5, pady=7)
        TK.Button(self.frame_control_main, text="Grafico Erro Relativo Umidade", width =30, command= self.bt_grafico_erro_relativo_umidade).grid(row=6, column=7, padx=5, pady=7)


        
        # self,interface.Tk()
        # self.interface.tittle("A3")
        # self.interface.grid()
    def bt_open_folder(self):
        global initialdir
        data_folder = TKFD.askdirectory(title="selecione o Data Folder", initialdir= __file__)
     
    pass
   
    
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

tempo, num = entradaArquivo("I:/Meus scrips/PYTHON/A3 Matematica/teste.csv")

def fazerGrafico(lista1, lista2):

    mate.plot(lista1, lista2, color = 'blue', alpha = 0.5)

    mate.xlabel("coluna_atual_de_datas")
    #mate.title("Temperatura, coluna_atual_de_datas")
    

    mate.legend()
    mate.show()

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

ys = pegarPolimofismo(num)

def fazerGraficoPolimorfico(eixo_x: list, lista_num_original : list, lista_dos_ys):
    mate.plot(eixo_x, lista_num_original, color = 'blue', alpha = 0.5)
    mate.plot(eixo_x, lista_dos_ys, color = 'red')

    

    mate.legend()
    mate.show() 
    
for x in num:

    fazerGrafico(tempo[0], x)
    
for m, n in zip(num, ys):

    fazerGraficoPolimorfico(tempo[0], m, n)
    
