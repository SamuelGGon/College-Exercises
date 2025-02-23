prod = float(input('Qual o valor do seu produto ? '))
pagame = input('Qual forma de pagamento ?\nDinheiro ou cheque\nCartão ')
if pagame == 'Dinheiro' or pagame == 'cheque' or pagame == 'dinheiro':
    x = prod - (prod*0.10)
    print(f'Seu produto tem o valor de R${prod:.2f} e por pagar com dineiro ou cheque tem desconto de 10%')
    print(f'terá o valor de R${x:.2f}')
elif pagame == 'Cartão' or pagame == 'cartão' or pagame == 'cartao':
    print('Será a vista ou em quantas parcelas ?')
    x = input('Por favor escreva só o número da parcela ou a vista ')
    
    if x == 'vista' or x == 'a vista' or x == '1':
        y = prod - (prod*0.05)
        print(f'Seu produto tem o valor de R${prod:.2f} e por pagar a vista no cartao, tera o valor de R${y:.2f}')
    elif x == '2':
        y = prod/2
        print(f'Seu produto tem o valor de R${prod:.2f} e por pagar em 2x, irá pagar ao mês R${y:.2f} ')
    elif int(x) >= 3:
        y = prod + (prod*0.20)
        z = y/int(x)
        print(f'Seu produto tem o valor de R${prod:.2f} e por pagar em {x}x, irá pagar com juros de 20%')
        print(f'e com juros o valor ficara R${y:.2f} e ficara ao mês R${z:.2f}')
