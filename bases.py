#!/usr/bin/env python

x1 = []

for i in '012345678':
    for j in '012345678':
        c1 = int('88' + str(i) + '4' + str(j), 9) + int('7' + str(i) + '44' + str(j), 11)
        if c1 % 61 == 0:
            z1 = c1 / 61
            x1.append(z1)

print(str(min(x1)))

x1 = []

for i in '0123456789ABC':
    for j in '0123456789ABC':
        c1 = int('8' + str(i) + '78' + str(j), 13) + int('79' + str(i) + str(j) + '7', 18)
        if c1 % 9 == 0:
            z1 = c1 / 9
            x1.append(z1)

print(str(min(x1)))

x1 = []

for i in '0123456789ABCDE':
    for j in '0123456789ABCDE':
        c1 = int('90' + str(i) + '4' + str(j), 15) + int('91' + str(i) + str(j) + '2', 16)
        if c1 % 56 == 0:
            z1 = c1 / 56
            x1.append(z1)

print(str(min(x1)))

x1 = []

for i in '0123456789A':
    for j in '0123456789A':
        c1 = int(str(i) + '341' + str(j), 11) + int('56' + str(i) + '1' + str(j), 19)
        if c1 % 305 == 0:
            z1 = c1 / 305
            x1.append(z1)

print(str(min(x1)))

x1 = []

for i in '0123456789AB':
    for j in '0123456789AB':
        c1 = int(str(i) + '231' + str(j), 12) + int('78' + str(i) + '98' + str(j), 14)
        if c1 % 99 == 0:
            z1 = c1 / 99
            x1.append(z1)

print(str(min(x1)))

x1 = []

for i in '0123456':
    for j in '0123456':
        c1 = int(str(j) + str(i)  + '320', 7) + int('1' + str(i) + '3' + str(j) + '3', 9)
        if c1 % 181 == 0:
            z1 = c1 / 181
            x1.append(z1)

print(str(min(x1)))

x1 = []

for i in '01234567':
    for j in '01234567':
        c1 = int(str(i) + '01' + str(j) + '4', 9) + int(str(i) + str(j) + '544', 8)
        if c1 % 89 == 0:
            z1 = c1 / 89
            x1.append(z1)

print(str(min(x1)))

x1 = []

for i in '0123456789AB':
    for j in '0123456789AB':
        c1 = int(str(j) + 'AA' + str(i), 12) + int(str(i) + '02' + str(j), 14)
        if c1 % 80 == 0:
            z1 = c1 / 80
            x1.append(z1)

print(str(min(x1)))