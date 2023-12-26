#!/usr/bin/env python

f = open('4.txt', 'r').readlines()

sq = []
for i in range(0, len(f)):
    if (f[i][len(f[i]) - 1] == 3):
        sq.append(int(f[i]) ** 2)

leastSquare = min(sq)

pairs = 0
sums = []

for i in range(0, len(f)):
    for j in range(0, len(f)):
        x = str(min(int(f[i], int(f[j]))))
        if i != j and x[len(x) - 1] == 3 and ((int(f[i]) ** 2) + (int(f[j]) ** 2)) > leastSquare:
            pairs += 1
            sums.append(int(f[i]) ** 2) + (int(f[j]) ** 2)

print(pairs, max(sums))


        