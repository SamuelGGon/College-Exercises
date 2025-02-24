while(True):
    Escolha=input ("1. Celsius para Fahrenheit\n1.2 Fahrenheit Para Celsius\n2. Celsius Para Kelvin"+
                "\n2.2 Kelvin para Celsius\n3. Fahrenheit para Kelvin\n3.2 Kelvin para Fahrenheit ") 
    if Escolha=="1":
        C=float(input("Colocar Temperatura em Celsius"))
        F=9*C+160
        F=F/5
        print("Resultado é")
        print(F)
    elif Escolha=="1.2":
        F=float(input("Colocar Temperatura em Fahrenheit"))
        C=5*F-160
        C=C/9
        print(C)
    elif Escolha=="2":
        C=float(input("Colocar Temperatura em Celsius"))
        K=273+C
        print(K)
    elif Escolha=="2.2":
        K=float(input("Colocar Temperatura em Kelvin"))
        C=K-273
        print(C)
    elif Escolha=="3":
        F=float(input("Colocar Temperatura em Fahrenheit"))
        K=F+459.4
        K=K/1.8
        print(K)
    elif Escolha=="3.2":
        K=float(input("Colocar Temperatura em Kelvin"))
        F=1.8*K-459.4
        print(F)
    EscolhaEncerrar=input("Deseja encerrar o Programa ?\n Sim\n Não ")
    if EscolhaEncerrar=="Sim" or EscolhaEncerrar=="sim" or EscolhaEncerrar=="s":
        break
    if EscolhaEncerrar=="Não" or EscolhaEncerrar=="não" or EscolhaEncerrar=="n":
        continue
    

     
    