num = int(input('Escolha um número para saber o fatorial: '))

contador = num
multi_nums = 0
multi_nums2 = 0

if num == 0:
    print(f'Fatorial de {num}! = 1')
    contador = 1
    
while contador != 1 :
    if num == contador:
        contador = contador - 1
        multi_nums = contador * num
        print(f'{num} x {contador} = {multi_nums}')
    elif contador <= num:
        contador = contador - 1
        multi_nums2 = multi_nums
        multi_nums = multi_nums * contador
        print(f'{multi_nums2} x {contador} = {multi_nums}')
print(f'O Resultado de {num}! = {multi_nums}')
        





        



    
    
    
