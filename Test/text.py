s = open('24.txt')
f = s.readline()
k = 1
m = 0

for i in range(0, len(f)):
    if f[i] == 'X' and f[i+1] == 'X':
        k += 1
    else:
        m = max(k, m)
        k = 1
m = max(k, m)
print(m)

