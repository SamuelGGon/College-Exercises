REGISTRO_criminal_da_somalia = 0
num1 = 0
num2 = 0
num3 = 0

print('Bem vindo a calculadora simples')
num1 = float(input('Digite seu 1º número: '))
num2 = float(input('Digite seu 2º número: '))

while REGISTRO_criminal_da_somalia != 5:
    print('Escolha a operação que deseja fazer\n[1] Somar\n[2] multiplicar\n[3] Qual o maior\n[4] Novos num')
    print('[5] Fechar o programa:')
    escolha = int(input(''))
    
    if escolha == 1:
        num3 = num1 + num2 
        print(f'A soma de {num1} e {num2} tem valor de {num3}')
    elif escolha == 2:
        num3 = num1 * num2
        print(f'A multiplicação de {num1} e {num2} tem o valor de {num3}')
    elif escolha == 3:
        if num1 > num2:
            print(f'O número {num1} é maior que {num2}')
        else:
            print(f'O número {num2} é maior que {num1}')
    elif escolha == 4:
        num1 = float(input('Digite seu 1º número: '))
        num2 = float(input('Digite seu 2º número: '))
    elif escolha == 5:
        REGISTRO_criminal_da_somalia = escolha

