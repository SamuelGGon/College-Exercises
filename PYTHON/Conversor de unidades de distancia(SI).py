# Km, Hm, Dam, M, Dm, Cm, MM
mano=float(input('Digite a medida em metros que será convertida '))
km=mano/1000
hm=mano/100
dam=mano/10
dm=mano*10
cm=mano*100
mm=mano*1000
print(f'A medida escolhida em metros foi {mano} e sua conversão para:\nKm: {km}', end='\n')
print(f'Hm: {hm}\nDam: {dam}\nM: {mano}\nDm: {dm}\nCm: {cm}\nMm: {mm}')
