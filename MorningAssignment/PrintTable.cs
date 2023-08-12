namespace MorningAssignment;

internal class PrintTable
{
    private int number;

    public PrintTable(int num)
    {
        number = num;
    }

    public void Table()
    {
        Console.WriteLine($"Table of {number}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}
