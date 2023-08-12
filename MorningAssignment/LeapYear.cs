namespace MorningAssignment;
internal class LeapYear
{
    public LeapYear(int year)
    {
        Year = year;
    }
    private int Year { get; }
    public bool IsLeapYear()
    {
        if ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0)
        {
            return true;
        }
        return false;
    }

}
