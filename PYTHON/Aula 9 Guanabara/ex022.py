nome = input('Digite seu nome completo: ')
a = nome.replace(' ', '')
a = len(a)
b = nome.split()
b = len(b[0])

print(f'Seu nome em maiúsculo: {nome.upper()}\nSeu nome em minúsculo: {nome.lower()}')
print(f'Seu nome ao todo tem {a} letras\nO seu primeiro nome tem {b} letras')

