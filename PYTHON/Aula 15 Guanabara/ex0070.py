nome_produto_barato = ''
barato = 0
caro = 0
produtos_mill_reais = 0
total_da_compra = 0
g = ''

while True:
    nome = str(input('Nome do produto: ')).upper().strip()
    preco = float(input('Preço do produto R$'))
    total_da_compra = total_da_compra + preco
    if barato == 0 and caro == 0:
        barato = caro = preco
        nome_produto_barato = nome
    elif preco > caro:
        caro = preco
    elif preco < barato:
        barato = preco
        nome_produto_barato = nome
    if preco >= 1000:
        produtos_mill_reais += 1
    saida = str(input('Deseja continuar ? [S/N]: ')).upper().strip()
    if saida != 'S' and  saida != 'N':
        while True:
            saida = str(input('Deseja continuar ? [S/N]: ')).upper().strip()
            if saida == 'S' or saida == 'N':
                break  
    if saida == 'N':
        break
print(f'{g:-^20}')
print(f'O total da compra foi de R${total_da_compra:.2f}\nO produto mais barato foi: {nome_produto_barato} e custou R${barato:.2f}')
print(f'No total você comprou [{produtos_mill_reais}] produtos que valem mil reais ou mais')
print(f'{g:-^20}')   
    




