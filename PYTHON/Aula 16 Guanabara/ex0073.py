clubs = ('Atlético-MG', 'Palmeiras', 'Fortaleza EC', 'Flamengo', 'Bragantino','Corinthians',
'Internacional', 'Fluminense', 'Athletico-PR', 'Cuiabá', 'Ceará','São Paulo', 
'Atlético Goianiense', 'Juventude', 'América-MG', 'Santos', 'Bahia', 'Grêmio', 
'Sport', 'Chapecoense', 'jurema', 'asa')

x = ''
contador = 0

print(f'Esses são os cinco, primeiros colocados {clubs[0:5]}')
print(f'Esses são os quatros, últimos colocados{clubs[-4:]}')
print(sorted(clubs))

for x in clubs:
    contador += 1
    if x == 'Chapecoense':
        print(f'A Chapecoense está na posição {contador}º')