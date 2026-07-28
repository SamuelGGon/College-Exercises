num_sexo = 0
nome1 = ''
num_idade = 0
novo = 0
velho = 0
mulher_menos20 = 0

for x in range(0, 4):
    nome = input('Qual seu nome ?: ')
    idade = int(input('Qual sua idade ?: '))
    sexo = input('Coloque seu sexo [F] Feminino/[M] Masculino: ').upper()
    
    num_idade += idade
    if x == 0:
        novo = velho = idade
    if velho <= idade:
        velho = idade
        if sexo == 'M':
            nome1 = nome
    if novo > idade:
        novo = idade
    if idade < 20:
        mulher_menos20 += 1
a = num_idade / 4
print(f'A média de idade do grupo {a}\nO homem mais velho é {nome1}\nTem {mulher_menos20} mulheres com menos de 20 anos')
            


    