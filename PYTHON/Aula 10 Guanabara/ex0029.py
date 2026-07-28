from random import randint

x = randint(0, 200)
if x > 80:
    y=(x-80)*7
    print(f'Amigão, ta rapido demais, {x}Km/h.\nTerei que te mutar\nSua multa tem o valor: R${y}' )
else:
    print('Grande respitor das leis de transito')



