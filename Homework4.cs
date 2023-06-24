using System;

public class Homework4 {
    
    public static void task1(int a, int b) {
        int number = 1;
        for (int i = 0; i < b; i++) {
            number *= a;
        }
        Console.WriteLine(number);
    }
    public static void task2(int number) {
        int sum = 0;
        while (number > 0) {
            sum += number % 10;
            number /= 10;
        }
        Console.WriteLine(sum);
    }
    public static void task3() {
        int[] array = new int[8];
        Random random = new Random();
        for (int i = 0; i < array.Length; i++) {
            array[i] = random.Next(100000);
        }
        Console.WriteLine(string.Join(", ", array));
    }
}