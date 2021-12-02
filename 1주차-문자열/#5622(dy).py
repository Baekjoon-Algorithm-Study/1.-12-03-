a = list(input())

i = 0
list_ = list()

for i in range(0, len(a), 1):

    if a[i] in ['A', 'B', 'C']:
        list_.append(3)

    elif a[i] in ['D', 'E', 'F']:
        list_.append(4)

    elif a[i] in ['G', 'H', 'I']:
        list_.append(5)

    elif a[i] in ['J', 'K', 'L']:
        list_.append(6)

    elif a[i] in ['M', 'N', 'O']:
        list_.append(7)

    elif a[i] in ['P', 'Q', 'R', 'S']:
        list_.append(8)

    elif a[i] in ['T', 'U', 'V']:
        list_.append(9)

    else:
        list_.append(10)



print(sum(list_))


