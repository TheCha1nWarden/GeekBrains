def task2(array, min, max):
    for i in range(len(array)):
        if array[i] >= min and array[i] <= max:
            print(array[i])