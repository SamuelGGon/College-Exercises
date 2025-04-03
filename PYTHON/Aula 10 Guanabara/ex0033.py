print('Por favor colocar três numeros, a seguir')
num1 = float(input('Primeiro numero '))
num2 = float(input('Segundo numero '))
num3 = float(input('Terceiro numero '))
print(f'Os numeros escolhidos foram: {num1}, {num2} e {num3}')
if num1 > num2:
    print(f'{num1} é maior que {num2}')
    if num1 > num3:
        print(f'{num1} é maior que {num3}')

if num2 > num1:
    print(f'{num2} é maior que {num1}')
    if num2 > num3:
        print(f'{num2} é maior que {num3}')

if num3 > num1:
    print(f'{num3} é maior que {num1}')
    if num3 > num2:
        print(f'{num3} é maior que {num2}')

if num1 == num2 == num3:
    print(f'Os numeros {num1}, {num2} e {num3} são iguais')



    