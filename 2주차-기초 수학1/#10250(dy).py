import math
import string

t = int(input())

for i in range(t):
    a, b, c = map(int, input().split())

    room_number = []

    if c % a == 0:
        room_number.append(a)

        if int(c / a) < 10 and math.ceil(c / a) < 10:
            room_number.extend([0, math.ceil(c / a)])

        else:
            room_number.append(math.ceil(c / a))
    else:
        if int(c / a) < 10 and math.ceil(c / a) < 10:
            room_number.extend([c % a, 0, math.ceil(c / a)])
        else:
            room_number.extend([c % a, math.ceil(c / a)])

    print("".join(map(str, room_number)))










