
num_entrada = 0
contador = 0
soma = 0
maior = 0 
menor = 0
saida = ''


while saida != 'N':
    entrada = int(input('Digite qualquer número: '))
    num_entrada = entrada
    soma = soma + num_entrada
    if maior == 0 and menor == 0:
        maior = menor = entrada
    elif entrada > maior:
        maior = entrada
    elif entrada < menor:
        menor = entrada
    contador += 1
    x = input('Deseja continuar ?: [S/N] ').upper()
    saida = x

media = soma / contador
print(f'A média dos números tem o valor de {media}\nO menor número digitado foi [{menor}]')
print(f'O maior número digitado foi [{maior}]')



















