lista = []
pares = []
impares = []

while True:
    lista.append(int(input('Digite um número: ')))
    while True:
        saida = input('Deseja continuar [S/N]: ').upper()
        if saida != 'S' and saida != 'N':
            saida = input('Deseja continuar [S/N]: ').upper()
        else:
            break
    if saida == 'N':
        break
for x in range(len(lista)):
    if lista[x] % 2 == 0:
        pares.append(lista[x])
    else:
        impares.append(lista[x])
print(f'Os números digitados foram:\n{lista}\nOs números pares são:\n{pares}\nOs números ímpares são:\n{impares}')


