namespace MorningAssignment;

internal class SumArrayElements
{
    public int SumArrayElement(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return sum;
    }
}
