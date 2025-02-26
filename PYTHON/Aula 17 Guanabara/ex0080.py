lista = []
save_guard = 0

for x in range(1, 6):
    num = int(input('Digite um número: '))
    if num >= 5:
        lista.insert(5, num)
    if num < 5:
        lista.insert(0, num)
    if x == 5:    
        if lista[0] > lista[1]:
            save_guard = lista[1]
            lista[1] = lista[0]
            lista[0] = save_guard
        if lista[1] > lista[2]:
            save_guard = lista[2]
            lista[2] = lista[1]
            lista[1] = save_guard
        if lista[2] > lista[3]:
            save_guard = lista[3]
            lista[3] = lista[2]
            lista[2] = save_guard
        if lista[3] > lista[4]:
            save_guard = lista[4]
            lista[4] = lista[3]
            lista[3] = save_guard
print(lista)







