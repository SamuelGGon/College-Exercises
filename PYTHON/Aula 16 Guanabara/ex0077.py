frase = ('macaco', 'arvore', 'jesus', 'python', 'historia', 'bem', 'feito', 'comida', 'celular', 'luar',
'estrela', 'sonho', 'furia', 'pao', 'bolo', 'batata', 'pudim', 'futebol', 'algebra')
y = ''
vogal = []

for x in range(0, len(frase)):
    if 'a' or 'e' or 'i' or 'o' or 'u' in frase[x]:
        y = frase[x]
        if 'a' in frase[x]:
            vogal.append('a')
        if 'e' in frase[x]:
            vogal.append('e')
        if 'i' in frase[x]:
            vogal.append('i')
        if 'o' in frase[x]:
            vogal.append('o')
        if 'u' in frase[x]:
            vogal.append('u')
        
        print(f'Na palavra: {y} temos as seguintes vogais: {vogal}')
        vogal = []












