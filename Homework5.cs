
using System;

public class Homework5
{
    
    public static void task1()
    {
        Random random = new Random();
        int[] array = new int[1 + random.Next(10)];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1000);
        }
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }

    public static void task2()
    {
        Random random = new Random();
        int[] array = new int[1 + random.Next(10)];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = -999 + random.Next(1998);
        }
        int sum = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }
        Console.WriteLine(sum);
    }

    public static void task3()
    {
        Random random = new Random();
        double[] array = new double[1 + random.Next(10)];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = -1000 + 1998 * random.NextDouble();
        }
        double min = array[0];
        double max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        Console.WriteLine(max - min);
    }
}