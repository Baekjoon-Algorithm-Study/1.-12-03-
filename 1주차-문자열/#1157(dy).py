
from collections import Counter



word = input().lower()
result = Counter(word)


for key, value in result.items():

    value_ = result.values()
    value_list = sorted(value_, reverse=True)
    maxValue = result.most_common(1)[0][0]

    if len(result) >= 2:
        if value_list[0] != value_list[1]:
            print(maxValue.upper())
        else:
            print('?')
    elif len(result) == 1:
        print(maxValue.upper())

    else:
        break
    break

