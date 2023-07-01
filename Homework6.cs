using System;

public class Homework6
{

    public static void task1()
    {
        int m = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i = 0; i < m; i++)
        {
            if (Convert.ToInt32(Console.ReadLine()) > 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }

    public static void task2()
    {
        int b1 = Convert.ToInt32(Console.ReadLine());
        int k1 = Convert.ToInt32(Console.ReadLine());
        int b2 = Convert.ToInt32(Console.ReadLine());
        int k2 = Convert.ToInt32(Console.ReadLine());
        double x = 1.0 * (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine("(" + x + "; " + y + ")");
    }
}

