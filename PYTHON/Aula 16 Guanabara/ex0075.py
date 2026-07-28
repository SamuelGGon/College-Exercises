quantos_9 = 0
posi_3 = 0
y = []


num1 = (int(input('Escreve um número qualquer: ')),
int(input('Mais um número: ')),
int(input('outro: ')),
int(input('Último número: '))
)

print(f'Os números foram {num1}')

for x in range(0, len(num1)):
    if num1[x] == 9:
        quantos_9 += 1
    if num1[x] % 2 == 0:
        y.append(num1[x])
    if num1[x] == 3:
        posi_3 = x + 1

print(f'O valor 9 apareceu {quantos_9} vezes') 
if posi_3 == 0:
    print('O 3 Não apareceu em nenhuma posição')
else:
    print(f'O valor 3 apareceu a primeira vez na posição {posi_3}º')
print(f'Os valores (Pares) digitados foram: {y}')
