soma_pares = 0

for x in range(0, 6):
    num = int(input('Coloque um numero que será somado: '))
    if num % 2 == 0:
        soma_pares += num
print(f'A Soma dos números pares colocados tem o resultado: {soma_pares}')

