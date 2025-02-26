from random import randint

CPU = randint(0, 10)
jogador = int(input('Escolha um numero de 0 a 10: '))

while jogador != CPU:
    print('Não, tente denovo ')
    jogador = int(input('Digite um numero '))
print(f'Parabéns você acertou, o computador escolheu [{CPU}] e você [{jogador}]')


