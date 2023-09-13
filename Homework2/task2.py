import sys

with open("input.txt", "r") as file:
    inputData = [int(num) for num in file.read().split()]

max = 0
if len(inputData) > 3:
    for i in range(len(inputData)):
        currentMax = 0
        currentMax += inputData[i]
        if i > 0:
            currentMax += inputData[i - 1]
        else:
            currentMax += inputData[len(inputData) - 1]
        if i < len(inputData) - 1:
            currentMax += inputData[i + 1]
        else:
            currentMax += inputData[0]
        if currentMax > max:
            max = currentMax
else:
    for inputDatum in inputData:
        max += inputDatum

print(max)