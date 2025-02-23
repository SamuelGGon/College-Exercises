#an = a1 + R(n-1)
termo1 = float(input('Colocar o primeiro termo da P.A: '))
razao = float(input('Colocar a razão da P.A: '))
soma = 0

for x in range(1, 11):
    soma = termo1
    termo1 += razao
    print(f'a{x} = {soma}')
print(f'A razão escolhida {razao}')




