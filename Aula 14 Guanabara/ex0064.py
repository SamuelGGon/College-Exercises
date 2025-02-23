
num_entrada = 0
soma = 0
contador = 0

while num_entrada != 999:
    entrada = int(input('Digite qualquer número: '))
    num_entrada = entrada
    if entrada != 999:
        contador += 1
        soma = soma + num_entrada
print(f'Foram digitados {contador} números e a soma deles tem esse valor {soma}')


















