km=float(input('Qual a distância que deseja percorrer ? '))
if km <= 200.00:
    x=km*0.50
    print(f'Sua viagem é menor que 200 Km. Ela terá uma cobrança de R${x}')
else:
    y=km*0.45
    print(f'Sua viagem é maior que 200 Km. Ela terá uma cobrança de R${y}')