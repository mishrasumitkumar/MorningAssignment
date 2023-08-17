namespace MorningAssignment;
internal class Program
{
    static void Main(string[] args)
    {
        //Console.Write("Enter Year: ");
        //int inputYear = Convert.ToInt32(Console.ReadLine());
        //LeapYear _numCheck = new LeapYear(inputYear);
        //bool isLeapYear = _numCheck.IsLeapYear();
        //if (isLeapYear)
        //{
        //    Console.WriteLine($"{inputYear} Leap Year.");
        //}
        //else
        //{
        //    Console.WriteLine($"{inputYear} not a Leap Year.");
        //}

        //Console.Write("Enter a number: ");
        //int inputNumber = Convert.ToInt32(Console.ReadLine());
        //PositiveOrNegative _numCheck = new PositiveOrNegative(inputNumber);
        //_numCheck._checknum();
        //Console.ReadLine();

        //Console.Write("Enter a number: ");
        //int num = Convert.ToInt32(Console.ReadLine());
        //OddOrEven checker = new OddOrEven(num);
        //checker.CheckEvenOdd();

        //Console.Write("Enter a number: ");
        //int number = Convert.ToInt32(Console.ReadLine());
        //Factorial calculator = new Factorial(number);
        //long factorial = calculator._factorial();
        //Console.WriteLine($"Factorial of {number} is: {factorial}");

        //Console.Write("Enter series number: ");
        //int limit = Convert.ToInt32(Console.ReadLine());
        //Fibonacci fibonacci = new Fibonacci(limit);
        //fibonacci.FSeries();
        //Console.ReadLine();

        //Console.Write("Enter a number: ");
        //int Input = Convert.ToInt32(Console.ReadLine());
        //PrimeOrNot _number = new PrimeOrNot(Input);
        //bool isPrime = _number.Primenumber();
        //if (isPrime)
        //{
        //    Console.WriteLine($"{Input} prime number.");
        //}
        //else
        //{
        //    Console.WriteLine($"{Input} not a prime number.");
        //}

        //NaturalNumber _Number = new NaturalNumber();
        //Console.Write("Enter a positive integer n: ");
        //int number = Convert.ToInt32(Console.ReadLine());
        //int Sum = _Number.Sum(number);
        //Console.WriteLine($"Sum of first {number} natural number: {Sum}");

        //Grade studentPercentage = new Grade();
        //studentPercentage.GetMarks();
        //studentPercentage.CalculateGrade();

        //Console.Write("Enter centimeters: ");
        //double cm = Convert.ToInt32(Console.ReadLine());
        //LengthConvert converter = new LengthConvert(cm);
        //double meters = converter.ConvertToMeters();
        //double kilometers = converter.ConvertToKilometers();
        //Console.WriteLine($"meters: {meters} ");
        //Console.WriteLine($"kilometers: {kilometers}");

        //Console.Write("Enter a number: ");
        //int num = Convert.ToInt32(Console.ReadLine());
        //PrintTable table = new PrintTable(num);
        //table.Table();

        //ReverseNumber reversenum = new ReverseNumber();
        //Console.Write("Enter a number: ");
        //int number = int.Parse(Console.ReadLine());
        //int reversedNumber = reversenum.Reversenumber(number);
        //Console.WriteLine($"Reverse of {number} is {reversedNumber}");

        //palindrome palindrom = new palindrome();    
        //Console.Write("Enter a number: ");
        //int num = int.Parse(Console.ReadLine());
        //if (palindrom.IsPalindrome(num))
        //{
        //    Console.WriteLine($"{num} is a palindrome.");
        //}
        //else
        //{
        //    Console.WriteLine($"{num} is not a palindrome.");
        //}

        //CountDigit countdigit = new CountDigit();
        //Console.Write("Enter a number: ");
        //int num = int.Parse(Console.ReadLine());
        //int digitCount = countdigit.CountDigits(num);
        //Console.WriteLine($"The number of digits in {num} is: {digitCount}");

        //GreaterNumber GreaterNumber = new GreaterNumber();
        //Console.WriteLine("Enter the first number:");
        //int num1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the second number:");
        //int num2 = Convert.ToInt32(Console.ReadLine());
        //int greaterNumber = GreaterNumber.Greaternumber(num1, num2);
        //Console.WriteLine($"The greater number between {num1} and {num2} is: {greaterNumber}");

        //AmrstrongNumber AmrstrongNumber = new AmrstrongNumber();
        //Console.WriteLine("Armstrong Numbers between 1 and 100:");
        //for (int i = 1; i <= 100; i++)
        //{
        //    if (AmrstrongNumber.IsArmstrongNumber(i))
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //RotateArray RotateArray = new RotateArray();
        //int[] arr = { 1, 2, 3, 4, 5 };
        //int rotations = 2;
        //Console.WriteLine("Original Array:");
        //RotateArray.PrintArray(arr);
        //RotateArray.LeftRotateArray(arr, rotations);
        //Console.WriteLine($"\nArray after {rotations} left rotations:");
        //RotateArray.PrintArray(arr);

        //SquarePattern SquarePattern = new SquarePattern();
        //Console.Write("Enter length of the square: ");
        //int sideLength = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Printing square pattern:");
        //SquarePattern.PrintSquare(sideLength);
        //Console.ReadLine();

        //RightTrianglePattern RightTrianglePattern = new RightTrianglePattern();
        //Console.Write("Enter height of the right triangle: ");
        //int height = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Right Triangle  Pattern:");
        //RightTrianglePattern.PrintRightTriangle(height);

        CountCharacters countCharacters = new CountCharacters();
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        int charCount = countCharacters.CountCharacter(input);
        Console.WriteLine($"Number of characters in the string: {charCount}");

        Console.Write("Enter a string containing numbers: ");
        //string input = Console.ReadLine();
        CountNumbers countNumbers = new CountNumbers();
        //CountNumbers.CountAllNumbers(input);


        SumArrayElements sumArrayElements = new SumArrayElements();
        Console.WriteLine("Enter the number of elements in the array:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int totalSum = sumArrayElements.SumArrayElement(array);
        Console.WriteLine("Sum of array elements: " + totalSum);

        NumberSwap numberSwap = new NumberSwap();
        double num1, num2;
        Console.Write("Enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Before swapping: num1 = {num1}, num2 = {num2}");
        numberSwap.Swap(ref num1, ref num2);
        Console.WriteLine($"After swapping: num1 = {num1}, num2 = {num2}");
    }
}