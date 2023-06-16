using System;

public class Homework2 {
    public void task1(int num) {
        Console.WriteLine(num / 10 % 10);
    }
    public void task2(int num) {
        if (num < 100) {
            Console.WriteLine("третьей цифры нет");
        } else {
            while (num > 999) {
                num /= 10;
            }
            Console.WriteLine(num % 10);
        }
    }
    public void task3(int num) {
        if (num < 6) {
            Console.WriteLine("нет");
        } else {
            Console.WriteLine("дв");
        }
    }
}
