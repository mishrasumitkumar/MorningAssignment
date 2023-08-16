namespace MorningAssignment;

public class CalculateGrade
{
    protected double Physics, Chemistry, Biology, Mathematics, Computer;

    public double CalculatePercentage()
    {
        return (Physics + Chemistry + Biology + Mathematics + Computer) / 5;
    }
    public void GetMarks()
    {
        Console.Write("Enter marks in Physics: ");
        Physics = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter marks in Chemistry: ");
        Chemistry = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter marks in Biology: ");
        Biology = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter marks in Mathematics: ");
        Mathematics = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter marks in Computer: ");
        Computer = Convert.ToDouble(Console.ReadLine());        
    }

}
public class Grade : CalculateGrade
{
    public void CalculateGrade()
    {
        double percentage = CalculatePercentage();

        Console.WriteLine("Percentage: " + percentage);

        if (percentage >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (percentage >= 80)
        {
            Console.WriteLine("Grade: B");
        }
        else if (percentage >= 70)
        {
            Console.WriteLine("Grade: C");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("Grade: D");
        }
        else if (percentage >= 40)
        {
            Console.WriteLine("Grade: E");
        }
        else
        {
            Console.WriteLine("Grade: F");
        }
    }
}
