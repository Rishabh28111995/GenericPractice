namespace StringCase;
class MaxString
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
        string max1 = MaxString.FindMax("Apple", "Peach", "Banana");
        Console.WriteLine($"Max. string is : {max1}");

    }
}