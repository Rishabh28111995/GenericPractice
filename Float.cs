namespace ProjectGen;

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
        float test1max = MaximumNumber.FindMax(10.0f, 6.0f, 4.0f);
        Console.WriteLine($"Test Case 1: {test1max}");

        
        float test2Max = MaximumNumber.FindMax(2.0f, 8.0f, 4.0f);
        Console.WriteLine($"Test Case 2: {test2Max}");

        
        float test3Max = MaximumNumber.FindMax(10.0f, 20.0f, 30.0f);
        Console.WriteLine($"Test Case 3: {test3Max}");
    }
}


