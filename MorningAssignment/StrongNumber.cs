using System.Reflection;

namespace MorningAssignment;

internal class StrongNumber
{
    public static int Factorial(int num)
    {
        if (num == 0 || num == 1)
            return 1;

        return num * Factorial(num - 1);
    }

    public bool IsStrongNumber(int num)
    {
        int originalNum = num;
        int sum = 0;

        while (num > 0)
        {
            int digit = num % 10;
            sum += Factorial(digit);
            num /= 10;
        }
        return sum == originalNum;

    }
}
