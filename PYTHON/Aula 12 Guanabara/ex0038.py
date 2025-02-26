num1 = int(input('Digite um numero '))
num2 = int(input('Digite outro numero '))
print(f'Os numeros escolhidos foram {num1} e {num2}')

if num1 > num2:
    print(f'O {num1} é maior')
elif num1 < num2:
    print(f'O {num2} é maior')
else:
    print(f'Os numeros {num1} e {num2} são  iguais')
