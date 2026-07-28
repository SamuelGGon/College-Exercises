print('Coloque quantos termos você gostaria que aparecesse na sequência de Fabonacci')

termo = int(input('Nº: '))

termo1 = 0
termo2 = 1
soma = 0
contador = 0

while contador != termo:
    soma = termo1 + termo2 
    termo2 = termo1
    termo1 = soma
    contador += 1
    print(f'Termo {contador} = {soma}')
    
