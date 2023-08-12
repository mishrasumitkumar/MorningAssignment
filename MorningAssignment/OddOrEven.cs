namespace MorningAssignment;

internal class OddOrEven
{    

    public OddOrEven(int num)
    {
        number = num;
    }
    private int number;

    public void CheckEvenOdd()
    {
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is even.");
        }
        else
        {
            Console.WriteLine($"{number} is odd.");
        }
    }
}
