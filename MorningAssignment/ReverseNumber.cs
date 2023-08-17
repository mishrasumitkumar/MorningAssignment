namespace MorningAssignment;
/// <summary>
///
// </summary>
internal class ReverseNumber
{
    public int Reversenumber(int num)
    {
        int reversed = 0;

        while (num > 0)
        {
            int remainder = num % 10;
            reversed = (reversed * 10) + remainder;
            num /= 10;
        }
        return reversed;
    }
}
