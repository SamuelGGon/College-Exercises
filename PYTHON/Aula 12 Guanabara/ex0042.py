print('O proposito desse programa é saber se os numeros colocados formam um triângulo')
a = float(input('Colocar a 1ª arresta '))
b = float(input('Colocar a 2ª arresta '))
c = float(input('Colocar a 3ª arresta '))
x = (a - b)
y = (a + b)
z = abs(x)
tri = z < c < y
if not tri:
    print('Não é um triângulo')
elif a == b == c:   
    print(f'Os valores dados {a}, {b} e {c} formam um triângulo equilátero')
elif a == b != c or a == c !=b or c == b != a: 
    print(f'Os valores dados {a}, {b} e {c} formam um triângulo isósceles')
elif a != b != c:
    print(f'Os valores dados {a}, {b} e {c} formam um triângulo escaleno')
else:
    print(f'Os valores dados {a}, {b} e {c} foram qualquer outro tipo de triângulo')