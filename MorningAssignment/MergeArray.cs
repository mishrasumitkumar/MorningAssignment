namespace MorningAssignment;

internal class MergeArray
{
    public int[] MergeArrays(int[] arr1, int[] arr2)
    {
        int[] mergedArray = new int[arr1.Length + arr2.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            mergedArray[i] = arr1[i];
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            mergedArray[arr1.Length + i] = arr2[i];
        }
        return mergedArray;
    }
}
