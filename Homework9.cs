using System;

public class Homework9 {
    public static void task1(int number) {
        Console.WriteLine(number);
        if (number > 1) {
            task1(--number);
        }
    }
    public static void task2(int m, int n) {
        int sum = 0;
        while (m <= n) {
            sum += m;
            m++;
        }
        Console.WriteLine(sum);
    }
    public static int task3(int m, int n){
        if(m == 0){
            return n+1;
        }else if(m > 0 && n == 0){
            return task3(m-1,1);
        }else{
            return task3(m-1, task3(m,n-1));
        }
    }
}