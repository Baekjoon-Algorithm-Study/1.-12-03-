
while True:
    list_ = list(map(int, input().split()))
    num = max(list_)
    list_.remove(num)
    if num == list_[0] == list_[1] == 0:
        break
    if num ** 2 == list_[0] ** 2 + list_[1] ** 2:
        print('right')

    else:
        print('wrong')

