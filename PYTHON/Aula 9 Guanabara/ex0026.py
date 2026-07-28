frase = input('Escreva uma frase: ').upper()
frase2 = frase.replace(' ', '')
a = frase2.count('A')
b = frase2.rfind('A')
c = frase2.find('A')

print(f'A frase escolhida foi: {frase}\nAparecem {a} vez(es) a letra [A]\nA letra [A] aparece', end=' ')
print(f'a primeira vez na posição {c+1}\nE a última vez que a letra [A] aparece, está na posição {b+1}')








