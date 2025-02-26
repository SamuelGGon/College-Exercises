ano=int(input('Colocar o ano que deseja saber se é bissexto: '))
if ano % 4 == 0 and ano % 100 != 0 or ano % 400 == 0:
    print('É um ano bissexto')
else:
    print('Não é um ano bissexto')


