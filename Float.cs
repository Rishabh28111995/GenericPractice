namespace ProjectGen;

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
        float test1max = MaximumNumber.FindMax(10.0f, 6.0f, 4.0f);
        Console.WriteLine($"Test Case 1: {test1max}");

        
        float test2Max = MaximumNumber.FindMax(2.0f, 8.0f, 4.0f);
        Console.WriteLine($"Test Case 2: {test2Max}");

        
        float test3Max = MaximumNumber.FindMax(10.0f, 20.0f, 30.0f);
        Console.WriteLine($"Test Case 3: {test3Max}");
    }
}


