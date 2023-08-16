namespace MorningAssignment;

internal class PositiveOrNegative
{    
    public PositiveOrNegative(int num)
    {
        number = num;
    }
    private int number;
    public void _checknum()
    {
        if (number > 0)
            Console.WriteLine("The number is positive.");
        else if (number < 0)
            Console.WriteLine("The number is negative.");
        else
            Console.WriteLine("The number is zero.");
    }
}
