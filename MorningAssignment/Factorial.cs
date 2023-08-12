namespace MorningAssignment;

public class Factorial
{   

    public Factorial(int num)
    {
        number = num;
    }
    private int number;

    public long _factorial()
    {
        if (number == 0 || number == 1)
            return 1;

        long factorial = 1;
        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}
