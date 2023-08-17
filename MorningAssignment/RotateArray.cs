namespace MorningAssignment;

internal class RotateArray
{

    public void LeftRotateArray(int[] arr, int rotations)
    {
        int length = arr.Length;
        for (int r = 0; r < rotations; r++)
        {
            int temp = arr[0];
            for (int i = 0; i < length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[length - 1] = temp;

            Console.WriteLine($"\nArray after {r + 1} rotation(s):");
            PrintArray(arr);
        }
    }
    public void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }
}
