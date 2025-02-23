reais_50 = 0
reais_20 = 0
reais_10 = 0
reais_1 = 0
g = ''
h = 'BANCO CENTRAL'

print(f'{g:=^20}\n{h:^20}\n{g:=^20}')
print('Quantos reais você gostaria de sacar ?')
sacar = int(input('R$'))
print(f'{g:-^30}')

while True:
    if sacar > 0:
        reais_50 = sacar // 50
        sacar = sacar % 50
        print(f'Total de {reais_50} cédulas de R$50')
        if reais_50 >= 0:
            reais_20 = sacar // 20
            sacar = sacar % 20
            if reais_20 > 0:
                print(f'Total de {reais_20} cédulas de R$20')
        if reais_20 >= 0:
            reais_10 = sacar // 10
            sacar = sacar % 10
            if reais_10 > 0:
                print(f'Total de {reais_10} cédulas de R$10')
        if reais_10 >= 0:
            reais_1 = sacar // 1
            sacar = sacar % 1
            if reais_1 > 0:
                print(f'Total de {reais_1} cédulas de R$1')
        if sacar == 0:
            break    
    else:
        break
print(f'{g:-^30}')        
                
             


    
    









