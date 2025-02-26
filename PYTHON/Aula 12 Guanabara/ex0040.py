num1 = float(input('Digite a sua  1ª nota '))
num2 = float(input('Digite a sua 2 ª nota '))
x = (num1 +num2)/2

if x < 5.0:
    print(f'Reprovado, sua nota foi: {x:.1f}')
elif 5.0 <= x <= 6.9:
    print(f'Recuperação, sua nota foi: {x:.1f}')
else:
    x >= 7.0
    print(f'Aprovado, sua nota foi: {x:.1f}')
