t = int(input())

for i in range(t):
    number, word = input().split()

    result = ''

    for k in word:
        result += int(number)*k
    print(result)
