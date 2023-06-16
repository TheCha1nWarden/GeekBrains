using System;

public class Homework1 {
    public void task1(int num1, int num2) {
        Console.WriteLine("max -> " + Math.Max(num1, num2));
    }
    public void task2(int num1, int num2, int num3) {
        Console.WriteLine(Math.Max(Math.Max(num1, num2), num3));
    }
    public void task3(int num) {
        if (num % 2 == 0) {
            Console.WriteLine("да");
        } else {
            Console.WriteLine("нет");
        }
    }
    public void task4(int n) {
        for (int i = 2; i < n; i += 2) {
            Console.Write(i + " ");
        }
    }
}
