lista = []
maior = 0
menor = 0
maior_pos = 0
menor_pos = 0


for x in range(0, 5):
    num = int(input('Digite um número: '))
    lista.append(num)
    if x == 0:
        maior = menor = num
    elif maior < num:
        maior = num
        maior_pos = x + 1
    elif menor > num:
        menor = num
        menor_pos = x + 1
print(f'A sua lista é: {lista}\nO maior número: {maior} e está na posição: {x}º...', end = '')
print(f'O menor número: {menor} e está na posição: {x}º...', end = '')




