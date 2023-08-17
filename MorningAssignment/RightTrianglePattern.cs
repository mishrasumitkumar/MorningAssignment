namespace MorningAssignment;

internal class RightTrianglePattern
{
    public void PrintRightTriangle(int height)
    {
        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
