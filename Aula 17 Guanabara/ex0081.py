lisa = []
num_cont = 0

while True:
    lisa.append(int(input('Digite um número: ')))
    num_cont += 1
    while True:
        saida = input('Deseja continuar [S/N]: ').upper()
        if saida != 'S' and saida != 'N':
            saida = input('Deseja continuar [S/N]: ').upper()
        else:
            break
    if saida == 'N':
        break
lisa.sort(reverse = True)
print(f'Você digitou: {num_cont} números\nA lista em ordem decrecente {lisa}')
if 5 in lisa:
    print('O valor 5 faz parte da lista')
else:
    print('O valor 5 não faz parte da lista')
    
    



