lista = []

while True:
    num = int(input('Digite um número: '))
    while True:
        if num in lista:
            num = int(input('O número já foi adicionado... Digite outro: '))
            if num not in lista:
                lista.append(num)
                while True:
                    escolha = input('Deseja continuar [S/N]: ').upper()
                    if escolha != 'S' and escolha != 'N':
                        escolha = input('Deseja continuar [S/N]: ').upper()
                    else:
                        break
                break
        elif num not in lista:
            lista.append(num)
            while True:
                escolha = input('Deseja continuar [S/N]: ').upper()
                if escolha != 'S' and escolha != 'N':
                    escolha = input('Deseja continuar [S/N]: ').upper()
                else:
                    break
            break
    else:
        lista.append(num)
        while True:
            escolha = input('Deseja continuar [S/N]: ').upper()
            if escolha != 'S' and escolha != 'N':
                escolha = input('Deseja continuar [S/N]: ').upper()
            else:
                break
    if escolha == 'N':
        break
print(f'Os número escolhidos foram:\n{sorted(lista)}')
            
            
        
                
      







