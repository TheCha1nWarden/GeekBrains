using System;

public class Homework7
{
   
    public static void task1(int m, int n)
    {
        double[,] array = new double[m, n];
        Random random = new Random();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = 100 * random.NextDouble();
            }
        }
    }

    public static void task2(int[,] array, int x, int y)
    {
        try
        {
            Console.WriteLine(array[x, y]);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Такого элемента нет");
        }
    }

    public static void task3(int[,] array)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            double sum = 0.0;
            for (int j = 0; j < array.GetLength(0); j++)
            {
                sum += array[j, i];
            }
            Console.WriteLine(sum / array.GetLength(0));
        }
    }
}