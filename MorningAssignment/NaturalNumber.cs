namespace MorningAssignment;

internal class NaturalNumber
{
    public int Sum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }
}
