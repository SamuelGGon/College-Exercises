num = int(input('Digite um número para saber se ele é primo: '))
multiplo = 0

for x in range(1, num + 1):
    if num % x == 0:
        multiplo += 1
if multiplo == 2:
    print(f'O {num} é primo')
else:
    print(f'o {num} não é primo')
print('FIM!')
    


    





