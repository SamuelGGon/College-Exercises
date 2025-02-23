num = int(input('Gostaria de saber a tabuada de qual valor ?: ')) 
contador = multi = 0
g = ''
print(f'{g:-^20}')

while True:
    if num < 0:
        break
    multi = num * contador
    print(f'{num} x {contador} = {multi}')
    contador += 1
    if multi == num * 10:
        print(f'{g:-^20}')
        num = int(input('Gostaria de saber a tabuada de qual valor ?: '))
        contador = multi = 0
print(f'Ainda não aprendi a fazer multiplicação de {num}, mas logo aprenderei')


        
    
    
    

