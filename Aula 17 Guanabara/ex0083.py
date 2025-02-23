lisa = []

input_user = str(input('Escreva uma expressão: '))
lisa.append(input_user)

if '(' in input_user[0] and ')' in input_user[-1]:
    print(f'Expressão valida {lisa}')
else:
    print(f'Expressão invalida {lisa}')


    















