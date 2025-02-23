from time import gmtime

meno_vm = 0
visao = 0


for x in range(0, 7):
    a = int(input('Qual o ano do seu nascimento: '))
    b = (a - gmtime().tm_year) * -1
    if b >= 18:
        visao +=1
    else:
        meno_vm += 1
print(f'Tem {visao} maiores de idade e tem {meno_vm} menores de idade')





