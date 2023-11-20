#!/usr/bin/env python

x1 = []

for i in '0123456789AB':
        c1 = int('3' + str(i) + 'DA', 14) + int('5' + str(i) + 'A6', 12)
        if c1 % 81 == 0:
            z1 = c1 / 81
            x1.append(z1)

print(str(min(x1)))

x1 = []

for i in '0123456789AB':
        c1 = int('2AB' + str(i), 12) + int(str(i) + '8E', 17)
        if c1 % 27 == 0:
            z1 = c1 / 27
            x1.append(z1)

print(str(min(x1)))