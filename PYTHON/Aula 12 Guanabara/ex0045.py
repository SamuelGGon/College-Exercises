from random import choice, shuffle

eg = ['e', 'a', 's', 't', 'e', 'r', ' ', 'e', 'g', 'g']
shuffle(eg)
eg = ''.join(eg)
print('Vamos jogar Pedra, Papel ou Tesoura')
x = input('Escolha Pedra, Papel ou Tesoura ')
y = choice(['pedra', 'papel', 'tesoura'])
x = x.lower()
y = y.lower()
#pedra>tesoura>papel>pedra
if x == y:
    print('Empate')
elif x == 'pedra' and y == 'tesoura':
    print(f'Você ganhou. {x} ganha de {y}')
elif x == 'tesoura' and y == 'papel':
    print(f'Você ganhou. {x} ganha de {y}')
elif x == 'papel' and y == 'pedra':
    print(f'Você ganhou. {x} ganha de {y}')
elif y == 'pedra' and x == 'tesoura':
    print(f'Você perdeu. {y} ganha de {x}')
elif y == 'tesoura' and x == 'papel':
    print(f'Você perdeu. {y} ganha de {x}')
elif y == 'papel' and x == 'pedra':
    print(f'Você perdeu. {y} ganhe de {x}')
elif x == 'easter egg':
    print('''
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
    ⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢸''')
else:
    print(f'Digitou nada ? uma dica para você ({eg})')



