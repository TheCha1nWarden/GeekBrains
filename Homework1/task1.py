array = [1, 0, 0, 1, 1]
tailCounter = 0
eagleCounter = 0
for i in range(len(array)):
    if array[i] == 0:
        tailCounter += 1
    if array[i] == 1:
        eagleCounter += 1
if tailCounter < eagleCounter:
    print("Нужно перевернуть", tailCounter, "монет с решкой")
else:
    print("Нужно перевернуть", eagleCounter, "монет с орлом")