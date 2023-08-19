namespace MorningAssignment;

internal class DeleteItemFromArray
{
    public int[] DeleteElement(int[] arr, int index)
    {
        if (index < 0 || index >= arr.Length)
        {
            return arr;
        }
        int[] result = new int[arr.Length - 1];

        for (int i = 0, j = 0; i < arr.Length; i++)
        {
            if (i != index)
            {
                result[j] = arr[i];
                j++;
            }
        }
        return result;
    }
}
