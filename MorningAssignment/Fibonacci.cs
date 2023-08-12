namespace MorningAssignment;

internal class Fibonacci
{  

    public Fibonacci(int num)
    {
        limit = num;
    }

    private int limit;

    public void FSeries()
    {
        int prev = 0, curr = 1;

        Console.WriteLine($"Fibonacci series {limit}:");

        while (prev <= limit)
        {
            Console.Write(prev + " ");

            int temp = prev + curr;
            prev = curr;
            curr = temp;
        }
        Console.WriteLine();
    }
}
