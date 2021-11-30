N = input()
a = [-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,]



for i in range(len(N)):
    s = ord(N[i]) - 97
    if a[s] == -1:
        a[s] = i
    else:
        continue
    
        

print(a)
for i in range(len(a)):
    print(a[i] , end=' ')
