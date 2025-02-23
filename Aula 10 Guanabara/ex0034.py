sal=float(input('Você acabou de ganhar um aumento no salário, por favor insira-o '))
if sal > 1250.00:
    x=sal*1.10
    print(f'Seu salário atual é: {sal} com o reajuste de 10% R${x:.2f}')

if sal <= 1250.00:
    y=sal*1.15
    print(f'Seu salário atual é: {sal} com o reajuste de 15% R${y:.2f}')
