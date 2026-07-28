soma = 0
for x in range(1, 501):
    if x % 2 == 1 and x % 3 == 0:
        soma = soma + x
        print(x)
print(f'A soma dos números a cima tem como resultado {soma}')
        
