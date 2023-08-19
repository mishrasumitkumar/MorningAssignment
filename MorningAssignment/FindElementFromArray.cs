namespace MorningAssignment;

internal class FindElementFromArray
{
    public int FindElement(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }
        }
        return -1;
    }
}
