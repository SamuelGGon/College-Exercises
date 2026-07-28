import pandas as pd
import matplotlib.pyplot as mate
import numpy as np
import statistics as st
# coluna 21 é as datas, colunas 22 é temperatura, coluna 23 é a umidade.

data = pd.read_csv("I:/Meus scrips/PYTHON/A3 Matematica/temperatura.csv")

tempo =  data.iloc[:,21]
temperatura = data.iloc[:,22]
umidade = data.iloc[:,23]

total_de_linhas = 2864

lista_de_ys_temperatura = []
lista_de_ys_umidade = []

float_temperatura = [float(t.replace(",", ".")) for t in temperatura]
float_umidade =  [float(u.replace(",", ".")) for u in umidade]


razao_umidade_sobre_temperatura = [ u / t for u, t in zip(float_umidade, float_temperatura)]


def primeiroGraficoTemperatura():
    mate.plot(tempo, float_temperatura, color = 'blue', alpha = 0.5, label = "Cada ponto tem um intervalo de 5 minutos do dia 25/07/2025 á 04/08/2025")

    mate.xlabel("Tempo")
    mate.ylabel("Temperatura")
    mate.title("Temperatura, tempo")
    mate.xticks([0, 2862])

    mate.legend()
    mate.show()

def segundoGraficoTemperatura():

    mate.plot(tempo, float_temperatura, color = 'blue', alpha = 0.5, label = "Cada ponto tem um intervalo de 5 minutos do dia 25/07/2025 á 04/08/2025")
    mate.plot(tempo, lista_de_ys_temperatura, color = 'red', label = "Tendencia")

    mate.xlabel("Tempo")
    mate.ylabel("Temperatura")
    mate.title("Temperatura, tempo")
    mate.xticks([0, 2862])

    mate.legend()
    mate.show()

def primeiroGraficoUmidade():
    mate.plot(tempo, float_umidade, color = 'green', alpha = 0.5, label = "Cada ponto tem um intervalo de 5 minutos do dia 25/07/2025 á 04/08/2025")
    
    mate.xlabel("Tempo")
    mate.ylabel("Umidade")
    mate.title("Umidade, Tempo")
    mate.xticks([0, 2862])

    mate.legend()
    mate.show()

def segundograficoUmidade():
    mate.plot(tempo, float_umidade, color = 'green', alpha = 0.5, label = "Cada ponto tem um intervalo de 5 minutos do dia 25/07/2025 á 04/08/2025")
    mate.plot(tempo, lista_de_ys_umidade, color = 'blue', label = "Tendencia")

    mate.xlabel("Tempo")
    mate.ylabel("Umidade")
    mate.title("Umidade, Tempo")
    mate.xticks([0, 2862])

    mate.legend()
    mate.show()

def graficoUmidadeSobreTemperatura():
    mate.plot(tempo, razao_umidade_sobre_temperatura, color = 'orange', alpha = 0.5, label = "Cada ponto tem um intervalo de 5 minutos do dia 25/07/2025 á 04/08/2025")
    mate.xlabel("Tempo")
    mate.ylabel("Umidade / Temperatura")
    mate.title("Umidade / Temperatura, Tempo")
    mate.xticks([0, 2862])

    mate.legend()
    mate.show()

    mate.show()

def verificadorDePolinomio(lista: list, x: float):
    #y = ax^2 + bx + c

    grau = len(lista) - 1
    y = 0
    
    for index in range(0, len(lista)):
        y += lista[index] * ((x ** (grau - index))) 
    
    
    return y
    
    # função de grau n, vai ser n coeficientes + 1

calcular_uma_vez = np.polyfit(range(1, len(float_temperatura) + 1), float_temperatura, 89)
calcular_uma_vez_umidade = np.polyfit(range(1, len(float_umidade) + 1), float_umidade, 89)



for tempe in range(1, len(float_temperatura) + 1):
        
    ys = verificadorDePolinomio(calcular_uma_vez, tempe)
    lista_de_ys_temperatura.append(ys)

print(lista_de_ys_temperatura)   
    
for umi in range(1, len(float_umidade) + 1):
    ys_umidade = verificadorDePolinomio(calcular_uma_vez_umidade, umi)
    lista_de_ys_umidade.append(ys_umidade)


def maiorEMenorUmidade():
    maior = menor = contador = 0

    for i in range(0, len(float_umidade)):
        
        if(contador == 0):
            maior = menor = float_umidade[i]
            contador = 1
        
        if (float_umidade[i] > maior):
            maior = float_umidade[i]

        if (float_umidade[i] < menor):
            menor = float_umidade[i]

    
    return f"{maior}---------------{menor}"

def maiorEMenorTemperatura():
    maior = menor = contador = 0

    for i in range(0, len(float_temperatura)):
        
        if(contador == 0):
            maior = menor = float_temperatura[i]
            contador = 1
        
        if (float_temperatura[i] > maior):
            maior = float_temperatura[i]

        if (float_temperatura[i] < menor):
            menor = float_temperatura[i]
    
    return f"{maior}---------------{menor}"

def modaUmidade():
    moda = {}

    for j in float_umidade:
        if (j in moda):
            moda[j] += 1
        else:
            moda[j] = 1

    resultado = sorted(moda.items(), key = lambda item: item[1], reverse = True)
    print(resultado[0])
        
def modaTemperatura():
    moda = {}

    for i in float_temperatura:
        if (i in moda):
            moda[i] += 1
        else:
            moda[i] = 1

    resultado = sorted(moda.items(), key = lambda item: item[1], reverse = True)
    print(resultado[0])
    
def mediaUmidade():
    soma = contagem = 0

    for f in float_umidade:
        soma += f
        contagem += 1
    
    return f"Media {(soma / contagem)}"

def mediaTemperatura():
    soma = contagem = 0

    for j in float_temperatura:
        soma += j
        contagem += 1

    return f"Media {(soma / contagem)}"

def medianaUmidade():
    ordem = sorted(float_umidade)
    total = 0
    
    for num in ordem:
        total += 1

    if (total % 2 == 0):

        posi = (total // 2) - 1

        resultado = (ordem[posi] + ordem[posi + 1]) / 2

        print(resultado)
    else:

        ordem[(total // 2)]
            
        print(ordem[(total // 2)]) 

def medianaTemperatura():
    ordem = sorted(float_umidade)
    total = 0
    
    for num in ordem:
        total += 1

    if (total % 2 == 0):

        posi = (total // 2) - 1

        resultado = (ordem[posi] + ordem[posi + 1]) / 2

        print(resultado)
    else:

        ordem[(total // 2)]
            
        print(ordem[(total // 2)]) 

def desvioPadrao(lista_de_numeros: list):
    return f"{st.stdev(lista_de_numeros):.4f}±"

def erroRelativo(lista_de_ys: list, lista_dos_numeros_brutos : list):

    lista_do_erro_relativo = []

    for y, bruto in zip(lista_de_ys, lista_dos_numeros_brutos):
        lista_do_erro_relativo.append((y - bruto) / bruto)
    
    return lista_do_erro_relativo
    
def graficoErroRelativoTemperatura():
    mate.plot(tempo, erroRelativo(lista_de_ys_temperatura, float_temperatura) , color = 'pink', alpha = 0.5, label = "Erro relativo temperatura")

    mate.xticks([0, 2862])

    mate.legend()
    mate.show()

def graficoErroRelativoUmidade():
    mate.plot(tempo, erroRelativo(lista_de_ys_umidade, float_umidade) , color = 'pink', alpha = 0.5, label = "Erro relativo umidade")

    mate.xticks([0, 2862])

    mate.legend()
    mate.show()













