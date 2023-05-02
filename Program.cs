using System;

public class MaximumNumber
{
    public static T FindMax<T>(T num1, T num2, T num3) where T : IComparable
    {
        T max = num1;
        if (num2.CompareTo(max) > 0)
        {
            max = num2;
        }
        if (num3.CompareTo(max) > 0)
        {
            max = num3;
        }
        return max;
    }
}


public class Program
{
    public static void Main()
    {
        int test1Num1 = 50;
        int test1Num2 = 10;
        int test1Num3 = 7;
        int test1Max = MaximumNumber.FindMax(test1Num1, test1Num2, test1Num3);
        Console.WriteLine($"Test Case 1: {test1Max}");

        int test2Num1 = 20;
        int test2Num2 = 40;
        int test2Num3 = 7;
        int test2Max = MaximumNumber.FindMax(test2Num1, test2Num2, test2Num3);
        Console.WriteLine($"Test Case 2: {test2Max}");

        int test3Num1 = 5;
        int test3Num2 = 10;
        int test3Num3 = 30;
        int test3Max = MaximumNumber.FindMax(test3Num1, test3Num2, test3Num3);
        Console.WriteLine($"Test Case 3: {test3Max}");
    }
}
