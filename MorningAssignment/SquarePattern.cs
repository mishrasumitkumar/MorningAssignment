namespace MorningAssignment;

internal class SquarePattern
{
    public void PrintSquare(int sideLength)
    {
        for (int i = 0; i < sideLength; i++)
        {
            for (int j = 0; j < sideLength; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
