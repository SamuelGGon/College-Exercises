from time import gmtime

print('A Confederação nacional de natação, está classificado alunos atrás vezes da sua faixa de idade ')
ano = int(input('Qual o ano que você nasceu ? '))
x = gmtime().tm_year
idade = (x - ano)

if idade <= 9:
    print(f'Sua idade é {idade} e você está na classe mirim')
elif idade <= 14:
    print(f'Sua idade é {idade} e você está na classe infantil')
elif idade <= 19:
    print(f'Sua idade é {idade} e você está na classe junior')
elif idade <= 25:
    print(f'Sua idade é {idade} e você está na classe sênior')
else:
    print(f'MESTRE')