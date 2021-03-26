podatki = [int(x) for x in input().split()]
sladkarije = [int(x) for x in input().split()]
janko = [int(x) for x in input().split()]
metka = [int(x) for x in input().split()]
janko.pop(0)
metka.pop(0)
nesortirano = []
for i in sladkarije:
    nesortirano.append(i)

sladkarije.sort()
najbolsih5 = sladkarije[-1:-podatki[1]-1:-1]

najbolsiIndexi = []
print(nesortirano)
x = 1
min = 200000000000000000000000000000000000000
for i in nesortirano:
    if i in najbolsih5 and i != min:
        najbolsiIndexi.append(x);
        if i < min:
            min = i
    x+=1
print(najbolsiIndexi)
while len(najbolsiIndexi & janko) < podatki[2]:
    print('asdf')