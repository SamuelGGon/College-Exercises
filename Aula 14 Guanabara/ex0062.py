# A1 + R(n - 1)

termo1 = float(input('Primeiro termo da PA: '))
razao = float(input('Razão da PA: '))
soma = termo1
contador = 1
cont_loop = 10

while contador != cont_loop:
    if soma == termo1:
        print(f'a{contador} = {soma}')
    soma += razao 
    contador += 1
    print(f'a{contador} = {soma}')
    if contador == cont_loop:
        x = input('Deseja continuar ? [S/N] ').upper()
        if x == 'S':
            y = float(input('Deseja ver mais quantos termos ?: '))
            cont_loop = cont_loop + y
            soma += razao
            contador += 1
            print(f'a{contador} = {soma}')
print('FIM')
        








