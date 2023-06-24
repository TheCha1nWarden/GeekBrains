
using System;

public class Homework3 {
    
    static void Main() {
        task3(5);
    }
    
    public static void task1(int number) {
        int copyNumber = number;
        int reversNumber = 0;
        while (copyNumber != 0) {
            reversNumber = reversNumber * 10 + copyNumber % 10;
            copyNumber /= 10;
        }
        if (reversNumber == number) {
            Console.WriteLine("да");
        } else {
            Console.WriteLine("нет");
        }
    }
    public static void task2(int x1, int y1, int z1, int x2, int y2, int z2) {
        Console.WriteLine(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)));
    }
    public static void task3(int number) {
        for (int i = 1; i <= number; i++) {
            Console.Write((int) Math.Pow(i, 3) + " ");
        }
    }
}
