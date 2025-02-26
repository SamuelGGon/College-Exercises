pesado = 0
leve = 0


for x in range(0, 5):
    a = float(input('Qual seu peso ? em KG: '))
    if x == 0:
        pesado = leve = a
    if pesado < a:
        pesado = a
    if leve > a:
        leve = a
print(f'A pessoa mais leve é {leve} e a pessoa mais pessada é {pesado}')
    



    
