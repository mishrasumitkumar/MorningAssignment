namespace MorningAssignment;

internal class AmrstrongNumber
{
    public bool IsArmstrongNumber(int num)
    {
        int originalNum = num;
        int sum = 0;
        int power = num.ToString().Length;

        while (num > 0)
        {
            int digit = num % 10;
            sum += (int)Math.Pow(digit, power);
            num /= 10;
        }
        return sum == originalNum;
    }
}
