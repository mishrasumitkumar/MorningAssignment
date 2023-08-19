namespace MorningAssignment;

internal class MultiplyArray
{
    public int[] MultiplyArrays(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            Console.WriteLine("Arrays must have the same length"); 
        }
        int[] result = new int[arr1.Length];

        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = arr1[i] * arr2[i];
        }
        return result;
    }
}
