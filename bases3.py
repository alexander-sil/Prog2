#!/usr/bin/env python

x1 = []

for i in '0123456789ABCDE':
        c1 = int('123' + str(i) + '5', 15) + int('1' + str(i) + '233', 15)
        if c1 % 14 == 0:
            z1 = c1 / 14
            x1.append(z1)

print(str(min(x1)))

x1 = []

for i in '0123456789ABCD':
        c1 = int('1' + str(i) + '563', 14) + int('871' + str(i) + '3', 14)
        if c1 % 24 == 0:
            z1 = c1 / 24
            x1.append(z1)

print(str(min(x1)))

for i in '0123456789A':
        c1 = int('982' + str(i) + '8', 11) + int('194' + str(i) + '7', 11)
        if c1 % 58 == 0:
            z1 = c1 / 58
            x1.append(z1)

print(str(min(x1)))

x1 = []

for i in '0123456789ABCDEF':
        c1 = int('8' + str(i) + '834', 16) + int('44' + str(i) + '27', 16)
        if c1 % 23 == 0:
            z1 = c1 / 23
            x1.append(z1)

print(str(min(x1)))

x1 = []

for i in '0123456789ABC':
        c1 = int('26' + str(i) + '98', 13) + int('4' + str(i) + '296', 13)
        if c1 % 34 == 0:
            z1 = c1 / 34
            x1.append(z1)

print(str(min(x1)))

x1 = []

for i in '0123456789ABCDEFGHI':
        c1 = int('321' + str(i) + '4', 19) + int('498' + str(i) + '9', 19)
        if c1 % 24 == 0:
            z1 = c1 / 24
            x1.append(z1)

print(str(min(x1)))

for a in range(1, 999):
    for x in '012345678':
        m = int('842' + x + '5', 9)
        n = int('8' + x + '725', 9)
        if (m + a) % n == 0:
              print(a)
              break
        
for a in range(1, 999):
    for x in '0123456789AB':
        m = int('49' + x + '26', 12)
        n = int('19' + x + '70', 12)
        if (m + a) % n == 0:
              print(a)
              break
        
for a in range(1, 999):
    for x in '0123456789ABCD':
        m = int('8' + x + '12' + x, 14)
        n = int('8' + x + '542', 14)
        if (m + a) % n == 0:
              print(a)
              break

for i in '0123456789ABCDEF':
        c1 = int('8' + str(i) + '84' + str(i), 16) + int('78' + str(i) + '34', 16)
        if c1 % 24 == 0:
            z1 = c1 / 24
            x1.append(z1)

print(str(min(x1)))