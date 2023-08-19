namespace MorningAssignment;

internal class PrintArrayItems
{
    public void PrintArrayItms(int[] arr)
    {
        Console.WriteLine("Array Items:");
        foreach (int item in arr)
        {
            Console.WriteLine(item);
        }
    }
}
