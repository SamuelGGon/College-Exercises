from matplotlib import pyplot
while True:
    EscolhaEq=input("1. Declive da reta\n2. interseção no eixo Y\n3. interseção no eixo X\n4. Equação da reta ")
    if EscolhaEq=="1":
        Y2=float(input("Por favor inserir o valor de YII "))
        Y1=float(input("Por favor inserir o valor de YI "))
        X2=float(input("Por favor inserir o valor de XII "))
        X1=float(input("Por favor inserir o valor de XI "))
        Declive=(Y2-Y1)/(X2-X1)
        print("O declive da sua reta = ")
        print(Declive)
    if EscolhaEq=="2":
        ipsilon=float(input("Por favor inserir o valor do ponto Y "))
        chiss=float(input("Por favor inserir o valor do ponto X "))
        declive=float(input("Por favor inserir o valor do Declive A "))
        interseção=ipsilon-declive*chiss
        print("A sua interseção no eixo Y = ")
        print(interseção)
    if EscolhaEq=="3":
        declive=float(input("Por favor inserir o valor do Declive A "))
        inter=float(input("Por favor inserir o valor da Interseção B "))
        x=0-inter/declive
        print("A sua interseção no eixo X = ")
        print(x)
    if EscolhaEq=="4":    
        declive=float(input("Por favor inserir o valor do Declive A "))
        chiss=float(input("Por favor inserir o valor do ponto X "))
        inter=float(input("Por favor inserir o valor de Interseção B "))
        y=declive*chiss+inter
        eixoX=[0, chiss]
        eixoY=[inter, y]
        pyplot.plot(eixoX, eixoY)
        pyplot.show()
        print("A sua reta é ")
        print(y)
    fim=input("Deseja encerrar o programa ?\nSim\nNão ")
    if fim=="Sim" or fim=="sim" or fim=="s":
        break
    if fim=="Não" or fim=="não" or fim=="n":
        continue
 

        
