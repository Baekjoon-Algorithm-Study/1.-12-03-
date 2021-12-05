a, b, c = map(int, input().split())
n = int()

if b < c:
    n = int(a/(c-b)) + 1
    print(n)
else:
    print(-1)