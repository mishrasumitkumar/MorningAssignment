namespace MorningAssignment;

internal class CountDigit
{
    public int CountDigits(int number)
    {
        int count = 0;
        while (number != 0)
        {
            number /= 10;
            count++;
        }
        return count;
    }
}
