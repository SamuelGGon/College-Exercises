from math import sqrt
raizq=input('Gostaria de tirar a raiz quadrada ? ')
if raizq=='Sim' or raizq=='s' or raizq=='sim':
    raizq2=float(input('Colocar o valor da sua raiz '))
    raizqua=sqrt(raizq2)
    print(f'A √{raizq2} tem como resultado {raizqua}')
else:
    raizcub=input('Gostaria de tirar raiz cubica ? ')
    if  raizcub=='Sim' or raizcub=='s' or raizcub=='sim':
        raizcub2=float(input('Colocar o valor da sua raiz cubica '))
        raizcubica=raizcub2**(1/3)
        print(f'A ³√{raizcub2} tem como resultado {raizcubica}')
    else:
        qualquer_raiz=input('Gostaria de tirar qualquer outra raiz ? ')
        if  qualquer_raiz=='Sim' or qualquer_raiz=='s' or qualquer_raiz=='sim':
            qualquer_raiz2=float(input('Colocar o valor do radicando '))
            qualquer_raiz3=float(input('Indice da raiz '))
            qualquer_raiz4=float(input('Expoente da raiz '))
            x=qualquer_raiz2**(qualquer_raiz4/qualquer_raiz3)
            print(x)
        else:
            print('Acabou')
        


