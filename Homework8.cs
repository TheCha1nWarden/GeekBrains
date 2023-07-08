using System;
using System.Linq;

public class Homework8
{

    public static void Task1(int[][] array)
    {
        foreach (int[] numbers in array)
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);
        }
        Console.WriteLine(string.Join(", ", array.Select(x => "[" + string.Join(", ", x) + "]")));
    }

    public static void Task2(int[][] array)
    {
        int num = 0;
        int minSum = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            int currentSum = 0;
            for (int j = 0; j < array[i].Length; j++)
            {
                currentSum += array[i][j];
            }
            if (currentSum < minSum)
            {
                minSum = currentSum;
                num = i + 1;
            }
        }
        Console.WriteLine(num);
    }

    public static void Task3(int[][] a, int[][] b)
    {
        int[][] result = new int[a.Length][];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = new int[b[0].Length];
            for (int j = 0; j < result[i].Length; j++)
            {
                int tmpRes = 0;
                for (int k = 0; k < b.Length; k++)
                {
                    tmpRes += a[i][k] * b[k][j];
                }
                result[i][j] = tmpRes;
            }
        }
        Console.WriteLine(string.Join(", ", result.Select(x => "[" + string.Join(", ", x) + "]")));
    }

    public static void Task4(int[][][] array)
    {
        string format = "({0},{1},{2})";
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                for (int k = 0; k < array[i][j].Length; k++)
                {
                    Console.Write(array[j][k][i] + string.Format(format, j, k, i));
                }
                Console.WriteLine();
            }
        }
    }

    public static void Task5()
    {
        int[,] array = new int[4, 4];
        int i = 0;
        int j = 0;
        for (int k = 1; k <= array.GetLength(0) * array.GetLength(1); k++)
        {
            array[i, j] = k;
            if (i <= j + 1 && i + j < array.GetLength(1) - 1)
                j++;
            else if (i < j && i + j >= array.GetLength(0) - 1)
                i++;
            else if (i >= j && i + j > array.GetLength(1) - 1)
                j--;
            else
                i--;
        }
        Console.WriteLine(string.Join(", ", array.Cast<int>()));
    }
}
