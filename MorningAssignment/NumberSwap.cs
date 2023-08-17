namespace MorningAssignment;

internal class NumberSwap
{
    public void Swap(ref double a, ref double b)
    {
        double temp = a;
        a = b;
        b = temp;
    }
}
