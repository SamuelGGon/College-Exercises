mult = float(input('Colocar um número que deseja saber a tabuada: '))
rang = int(input('Colocar o alcance da sua tabuada: '))
result_mult = 0 
o = 'Sua tabuada'
i = 'Fim'

print(f'{o:-^45}')
for x in range(0, rang + 1):
    result_mult = mult * x
    print(f'{x} X {mult} = {result_mult}')
print(f'{i:-^45}')


