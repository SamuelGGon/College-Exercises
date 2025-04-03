print('Iremos descobrir se os segmentos de reta inseridos formam um triângulo')
a = float(input('Primeiro segmento '))
b = float(input('Segundo segmento '))
c = float(input('terceiro segmento '))
x=a-c
y=abs(x)
z=a+b
if y < b < z:
    print(f'Com os segmentos de retas {a}, {b} e {c}\nConcluimos que forma um triângulo')
else:
    print(f'Com os segmentos de retas {a}, {b} e {c}\nConcluimos que não formam um triângulo')
