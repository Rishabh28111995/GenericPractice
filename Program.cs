using System;

public class MaximumNumber
{
    public static T FindMax<T>(T numOne, T numTwo, T numThree) where T : IComparable
    {
        T max = numOne;
        if (numTwo.CompareTo(max) > 0)
        {
            max = numTwo;
        }
        if (numThree.CompareTo(max) > 0)
        {
            max = numThree;
        }
        return max;
    }
}


public class Program
{
    public static void Main()
    {
        int test1NumOne = 50;
        int test1NumTwo = 10;
        int test1NumThree = 7;
        int test1Max = MaximumNumber.FindMax(test1NumOne, test1NumTwo, test1NumThree);
        Console.WriteLine($"Test Case 1: {test1Max}");

        int test2NumOne = 20;
        int test2NumTwo = 40;
        int test2NumThree = 7;
        int test2Max = MaximumNumber.FindMax(test2NumOne, test2NumTwo, test2NumThree);
        Console.WriteLine($"Test Case 2: {test2Max}");

        int test3NumOne = 5;
        int test3NumTwo = 10;
        int test3NumThree = 30;
        int test3Max = MaximumNumber.FindMax(test3NumOne, test3NumTwo, test3NumThree);
        Console.WriteLine($"Test Case 3: {test3Max}");
    }
}
