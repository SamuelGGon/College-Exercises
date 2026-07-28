from random import randint

CPU = randint(1, 10)
print('Vamos jogar Par ou Ímpar! Só para quando perder')
num_jogador = int(input('Escolha um número 1 a 10: '))
jogador = str(input('Escolha PAR ou Ímpar [P/I]: ')).upper().strip()
vitoria = 0

if jogador != 'I' and jogador != 'P':
    while True:
        jogador = str(input('Escolha PAR ou Ímpar [P/I]: ')).upper().strip()
        if jogador == 'I' or jogador == 'P':
            break

while True:
    resultado = num_jogador + CPU
    if jogador == 'I':
        resultado %= 2
        if resultado >= 1:
            print('Você ganhou, vamos jogar de novo')
            vitoria += 1
            CPU = randint(1, 10)
            num_jogador = int(input('Escolha um número 1 a 10: '))
            jogador = str(input('Escolha PAR ou Ímpar [P/I]: ')).upper().strip()
            if jogador != 'I' and jogador != 'P':
                while True:
                    jogador = str(input('Escolha PAR ou Ímpar [P/I]: ')).upper().strip()
                    if jogador == 'I' or jogador == 'P':
                        break
        else:
            print('Perdeu!')
            break
    elif jogador == 'P':
        resultado %= 2
        if resultado == 0:
            print('Você ganhou, vamos jogar de novo')
            vitoria += 1
            CPU = randint(1, 10)
            num_jogador = int(input('Escolha um número 1 a 10: '))
            jogador = str(input('Escolha PAR ou Ímpar [P/I]: ')).upper().strip()
            if jogador != 'I' and jogador != 'P':
                while True:
                    jogador = str(input('Escolha PAR ou Ímpar [P/I]: ')).upper().strip()
                    if jogador == 'I' or jogador == 'P':
                        break
        else:
            print('Perdeu')
            break


print(f'Você obteve um total de {vitoria} vitórias')
