n = int(input())
l = []

while 3 <= n <= 5000:
    if n % 5 == 0:
        l.append(n / 5)
    elif (n % 5) % 3 == 0:
        l.extend([n / 5, (n % 5) / 3])
    elif n % 3 == 0:
        if (n - 12)%5 == 0:
            l.extend([4, (n - 12) / 5])
        else :
            l.append(n/3)

    else:
        l.append(-1)
    break




print(int(sum(l)))
n = int(input())
l = []

while 3 <= n <= 5000:
    if n % 5 == 0:
        l.append(n / 5)
    elif (n % 5) % 3 == 0:
        l.extend([n / 5, (n % 5) / 3])
    elif n % 3 == 0:
        if (n - 12)%5 == 0:
            l.extend([4, (n - 12) / 5])
        else (n-6)%5 == 0:
            l.extend([2, (n-6)/5])
        else :
            l.append(n/3)

    else:
        l.append(-1)
    break




print(int(sum(l)))
