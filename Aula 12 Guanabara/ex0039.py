from time import gmtime

print('Gostaria de saber, se vai precisar alistar-se ao exército ?')
ano = int(input('Digite o ano que você nasceu '))
x = gmtime().tm_year
if (x - ano) < 18:
    y = ((x - ano) - 18)*-1
    print(f'Ainda não está em tempos de você se alista te faltam {y} ano(s)')
elif (x - ano) == 18:
    print(f'Está em tempos de se alistar, você possui exatamente 18 anos')
else: 
    (x - ano) > 18
    h = (x - ano) - 18
    print(f'Já passou do tempo para você se alistar, está atrassado {h} ano(s)')
