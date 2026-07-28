extenso = ('zero', 'um', 'dois', 'três', 'quatro', 'cinco', 'seis', 'sete', 'oito', 'nove', 'dez',
'onze', 'doze', 'treze', 'catorze', 'quinze', 'dezesseis', 'dezesete', 'dezoito', 'dezenove', 'vinte')

escolha = int(input('Escolha um número de 0 á 20: '))
while True:
    if escolha in range(0, 21):
        break
    else:
        escolha = int(input('Tente novamente. Escolha um número de 0 á 20: '))
print(f'você escolheu {escolha} e estamos escrevendo por extenso [{extenso[escolha]}]')

desejo = str(input('Deseja continuar ? [S/N]: ')).upper()
while True:
    if desejo == 'S' or desejo == 'N':
        if desejo == 'S':
            escolha = int(input('Escolha um número de 0 á 20: '))
            print(f'você escolheu {escolha} e estamos escrevendo por extenso [{extenso[escolha]}]')
            desejo = str(input('Deseja continuar ? [S/N]: ')).upper()
        else:
            print('Programa finalizado')
            break
    else:
        desejo = str(input(f'Deseja continuar ? [S/N]: ')).upper()        








