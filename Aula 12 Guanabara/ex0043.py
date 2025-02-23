massa = float(input('Por favor colocar seu peso em Kilogramas '))
altura = float(input('Por favor colocar sua altura '))
imc = massa/(altura**2)

if imc < 18.5:
    print(f'Seu IMC deu {imc:.1f} está abaixo do peso ideal ')
elif imc < 25:
    print(f'Seu IMC deu {imc:.1f} seu peso está ideal ')
elif imc < 30:
    print(f'Seu IMC deu {imc:.1f} você está em sobrepeso ')
elif imc < 40:
    print(f'Seu IMC deu {imc:.1f} você está obeso ')
else:
    print(f'Seu IMC deu {imc:.1f} você está em obesidade mórbida')

 
