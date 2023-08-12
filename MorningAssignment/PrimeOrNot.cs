namespace MorningAssignment;

internal class PrimeOrNot
{    
    public PrimeOrNot(int num)
    {
        number = num;
    }

    private int number;

    public bool Primenumber()
    {
        if (number <= 1)
            return false;

        if (number <= 3)
            return true;

        if (number % 2 == 0 || number % 3 == 0)
            return false;

        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }
        return true;
    }
}
