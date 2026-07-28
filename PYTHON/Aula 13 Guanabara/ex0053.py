frase = input('Escreva uma frase: ').lower()
frase.replace(' ', '')
a = len(frase)
a -= 1
vazio =  ''

for x in range(a, -1, -1):
    vazio += frase[x]   
if frase ==  vazio:
    print(f'{frase} é um palíndro')
else:
    print(f'{frase} não é um palíndro')




