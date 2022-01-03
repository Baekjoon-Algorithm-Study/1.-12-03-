
list1 = list()
list2 = list()

for i in range(3):
    a, b = map(int, input().split())
    list1.append(a)
    list2.append(b)

for i in range(3):
    if list1.count(list1[i]) == 1:
        a = list1[i]
    if list2.count(list2[i]) == 1:
        b = list2[i]

print(a, b)

