namespace MorningAssignment;

internal class AddUsingRecursion
{
    private static int count = 1;  
    public  int sum = 0;
    public void AddNumbers()
    {
        if (count <= 10)
        {
            sum += count;
            count++;
            AddNumbers(); 
        }
    }
}
