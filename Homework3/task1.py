import sys

a = int(input())
d = int(input())
n = int(input())
array = [0] * n
array[0] = a
for i in range(1, n):
    array[i] = array[i - 1] + d
print(array)