import time

def escritaDaley (texto, deley = 0.1):
    for letra in texto:
        print(letra, end = '', flush = True)
        time.sleep(deley)
    print()

print('Qualquer BUG, reportar ao criador')
escritaDaley('Carregando...', deley = 0.3)
escritaDaley('Carregando...', deley = 0.3)
escritaDaley('Carregando...', deley = 0.3 )

escritaDaley('Você está em sua casa, até que uma entidade surge...')
escritaDaley('Ela começa fazer - te perguntas')
