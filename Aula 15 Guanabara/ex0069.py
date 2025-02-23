homens = 0
mais_18 = 0
mulher_menos_20 = 0
g = ''

while True:
    sexo = str(input('Qual seu sexo ? [M/F]: ')).upper().strip()
    if sexo != 'M' and sexo != 'F': 
         while True:
            sexo = str(input('Qual seu sexo ? [M/F]: ')).upper().strip()
            if sexo == 'M' or sexo == 'F':
                break
    idade = int(input('Qual sua idade ?: '))
    if idade >= 18:
        mais_18 += 1
    if sexo == 'M':
        homens += 1
    elif sexo == 'F' and idade < 20:
        mulher_menos_20 += 1
    user_escolha = str(input('Deseja continuar ? [S/N]: ')).upper().strip()
    if user_escolha != 'N' and user_escolha != 'S':
        while True:
            user_escolha = str(input('Deseja continuar ? [S/N]: ')).upper().strip()
            if user_escolha == 'S' or user_escolha == 'N':
                break
    if user_escolha == 'N':
        break
    
print(f'{g:-^20}')
print(f'Nesse cadastro há\n[{mais_18}] Pessoas com mais de 18 anos\nforam cadastrados [{homens}] Homens')
print(f'e exite [{mulher_menos_20}] mulheres com menos de 20 anos')

        
     
       
