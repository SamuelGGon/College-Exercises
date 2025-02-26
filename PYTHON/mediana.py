lista = [2, 5, 3, 2, 8, 3, 5, 2, 3, 3]


frenquencia = numero = 0

for x in range(0, len(lista)):


    for y in range(0, len(lista)):
        if y == len(lista) - 1:
            break
        else:

            if y == 0:
                frenquencia = numero = lista[y]

            if lista[y] == lista[y + 1]:
                frenquencia += 1
                numero = lista[y]



        
