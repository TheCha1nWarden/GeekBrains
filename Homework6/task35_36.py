import re

def task35():
    pattern = re.compile("[аеёиоуыэюя]")
    s = input()
    words = s.split(" ")
    countVowels = len(re.findall(pattern, words[0]))
    flag = True
    for i in range(1, len(words)):
        tmpCountVowels = len(re.findall(pattern, words[i]))
        if tmpCountVowels != countVowels:
            flag = False
            break
    if flag:
        print("Парам пам-пам")
    else:
        print("Пам парам")

def task36(function, num1, num2):
    for i in range(1, num1+1):
        for j in range(1, num2+1):
            print(function(i, j), end=" ")
        print()