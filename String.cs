namespace StringCase;
class MaxString
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
        string max1 = MaxString.FindMax("Apple", "Peach", "Banana");
        Console.WriteLine($"Max. string is : {max1}");

    }
}
