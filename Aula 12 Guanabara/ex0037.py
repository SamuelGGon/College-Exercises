num = int(input('Digite um numero '))
x = input('Deseja converter esse numero para: \nBinário digite 1\nOcta digite 2\nHexadecimal digite 3\n')

if x == '1':
    print(f'O numero que você digitou foi {num} e ele em Binário: {num:b}')
elif x == '2':
    print(f'O numero que você digitou foi {num} e ele em Octa {num:o}')
elif x == '3':
    print(f'O numero que você digitou foi {num} e ele em Hexadecimal {num:x}')
else:
    print(f'O numero que você digitou foi {num} ')

