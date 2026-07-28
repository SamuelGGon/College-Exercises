casa = float(input('Qual o valor da casa dos sonhos ? '))
sal = float(input('Qual o seu salário ? '))
meses = int(input('Quantos anos deseja financiar sua casa ? '))
meses = meses*12
x = casa/meses
y = sal*0.30
if y >= x:
    print(f'''
    ⣿⣿⠟⠁⠄⢤⣰⣶⣕⡝⠷⠙⠻⢨⡁⣨⣙⠳⢈⣉⡛⠿⡟⠸⠸⡟⣇⢻⣿
    ⣿⠏⠄⠄⢴⣿⣿⠮⢫⣴⣾⣿⣿⣿⣿⣿⣿⣷⣾⣿⠿⢶⣴⣷⣆⡁⠇⢸⣿
    ⠇⠄⢘⣻⣿⣛⠊⣰⣿⣿⣿⣿⣿⣿⡿⢟⠯⠭⠿⣛⡻⢶⡿⣿⣿⣧⠄⣼⣿
    ⠄⠄⠠⣿⣿⣂⠐⣿⣿⣿⣿⣿⣟⡁⢀⣐⣒⠂⠄⠢⣬⡜⠡⣿⡈⠝⠆⠻⣿
    ⠄⡜⠢⠙⣟⡮⢐⣿⣿⣿⣿⣿⣿⣷⣌⠩⠋⠒⠂⠒⣸⡇⢰⣿⡌⠁⣀⠄⢹
    ⢰⠄⠻⠂⣻⣍⠠⣿⣿⠻⣿⣿⣿⣿⣿⣿⣷⣶⣶⡿⠟⠁⢸⣿⣧⠄⠈⠁⣺
    ⠘⣄⣀⠡⣾⣯⡄⢺⣿⡄⠙⢿⣿⣿⣿⣿⣿⣿⣟⡰⡋⠐⠲⠿⣿⡷⢸⣷⡌
    ⣦⠈⠄⣼⣿⣫⣤⡽⢙⢳⡀⠄⠉⠛⢛⣿⡿⠟⣻⣿⠶⠾⣿⣷⣶⣤⡼⣿⠃
    ⣿⠄⠄⢸⣿⣿⣿⣷⣿⡀⣡⠄⢀⣾⣿⠋⠄⠈⣁⣒⠒⠲⠦⢭⣛⣛⡁⠁⣼
    ⣿⠄⠄⠘⣿⣿⣿⣿⣿⣾⣿⣶⡀⢻⣿⣆⠄⡀⠊⢝⣛⠷⢶⢶⣶⣬⠙⢸⣿
    ⡟⠄⠄⠄⠹⣿⣿⣿⣿⣿⣿⣿⣿⡌⢿⣿⡆⣿⣦⣀⠉⠉⠓⠒⠲⠶⠖⢀⣿
    ⠁⠄⠄⠄⠄⠙⢿⣿⣿⣿⣿⣿⣿⡇⢸⣿⣿⣿⣿⣿⣿⣿⣿⣶⣶⣤⣤⠈⣿
    ⠄⠄⠄⠄⠄⠄⠄⠙⠻⠿⠿⠿⠟⠁⠄⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡆⢹
    ⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢸
    Você tem o direito de financiar sua casa. Pois com 30% do seu salário R${y:.2f} ira pagar parcelas de R${x:.2f} ''')
elif y < x:
    print('Ai é pegado, da não pai')




