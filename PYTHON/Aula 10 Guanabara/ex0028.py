from random import randint
from audioplayer import AudioPlayer

x = randint(0, 5)
y = int(input('Escolha um numero de 0 a 5: '))    
if x == y:
    print('\033[3;32mTu ganho parabens\033[m')
    AudioPlayer("I:/Programação/Meus scrips/Aula 10 Guanabara/Anime WOW - Sound Effect (HD)_160k.mp3").play(block=True)
else:
    print('\033[3;31mTu perdeu irmãozinho\033[m')
    AudioPlayer("I:/Programação/Meus scrips/Aula 10 Guanabara/The Price is Right Losing Horn - Gaming Sound Effect (HD)_160k.mp3").play(block=True)



