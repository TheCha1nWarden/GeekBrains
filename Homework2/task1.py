import sys
n = int(input())
m = int(input())
list1 = []
list2 = []
for i in range(n):
    list1.append(int(input()))
for i in range(m):
    list2.append(int(input()))
setResult = set(list1 + list2)
print(setResult)
