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
        c1 = int('8' + str(i) + '78' + str(i), 13) + int('79' + str(i) + str(i) + '7', 18)
        if c1 % 9 == 0:
            z1 = c1 / 9
            x1.append(z1)

print(str(min(x1)))