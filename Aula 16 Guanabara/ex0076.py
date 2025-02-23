lista_de_compra = ('Lápis', 7.50, 'Borracha', 2.00, 'Caderno', 15.90, 'Estojo', 25.00, 'Transferidor', 4.20, 
'Compasso', 9.99, 'Mochila', 120.32, 'Canetas', 22.30, 'Livro', 34.90)

for y in range(0, len(lista_de_compra), 2):
    print(f'{lista_de_compra[y]:.<30}R${lista_de_compra[y+1]:>3.2f}')











