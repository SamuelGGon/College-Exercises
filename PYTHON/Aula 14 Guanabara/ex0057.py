masculino = feminino = 0


while masculino != 1 and feminino != 1:
    sexo = input('Qual vosso sexo ?: [M/F] ').upper().strip()
    if sexo == 'M':
        masculino =+ 1
    elif sexo == 'F':
        feminino =+ 1

if masculino == 1:
    print(f'parabens você é do sexo masculino')
elif feminino == 1:
    print(f'parabens você é do sexo feminimo')


