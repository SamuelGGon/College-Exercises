#A1 + R(N - 1)

termo1 = float(input('O primeiro termo da PA: '))
razao = float(input('A razão da PA: '))
soma = termo1
contador = 1

while contador != 10:
    if soma == termo1:
        print(f'a{contador} = {soma}')
    soma += razao
    contador += 1
    print(f'a{contador} = {soma}')
print('FIM!!')
   
    









