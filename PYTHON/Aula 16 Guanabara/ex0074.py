from random import randint

CPU = randint(1, 10)

CPU1 = CPU2 = CPU3 = CPU4 = CPU5 = 0
maior = menor = 0

while True:
    if CPU1 <= 0:
        CPU1 = CPU
        CPU = randint(1, 10)
    if CPU2 <= 0:
        CPU2 = CPU
        CPU = randint(1, 10)
    if CPU3 <= 0:
        CPU3 = CPU
        CPU = randint(1, 10)
    if CPU4 <= 0:
        CPU4 = CPU
        CPU = randint(1, 10)
    if CPU5 <= 0:
        CPU5 = CPU
    else:
        break    

supla = (CPU1, CPU2, CPU3, CPU4, CPU5)

for x in supla:
    if maior == 0 and menor == 0:
        menor = maior = CPU1
    elif x > maior:
        maior = x
    elif x < menor:
        menor = x


    
print(f'O números sorteados foram: {supla}\nO maior número sorteado foi {maior}\nO menor número sorteado foi {menor}')
    
    

