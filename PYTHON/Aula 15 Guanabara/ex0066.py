soma = contador = 0

while True:
    num = int(input('Digite qualquer número [Parada 999]: '))
    if num == 999:
        break
    soma = soma + num
    contador += 1
print(f'Foram digitados {contador} números\ne a soma entre eles tem o valor de {soma}')











