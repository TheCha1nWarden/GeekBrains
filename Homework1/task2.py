x = 45
y = 3


S = x + y
P = x * y
stop = 0
for i in range(1001):
    if stop != 1:
        for j in range(1001):
            if stop != 1:
                if i * j == P and i + j == S:
                    print(i, j)
                    stop = 1
        else:
            j = 1001
    else:
        i = 1001