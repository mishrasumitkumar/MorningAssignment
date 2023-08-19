namespace MorningAssignment;

internal class NamePattern
{
    public void PrintNamePattern(string name)
    {
        string[] starPatterns = {
            "  *  ",   // A
            "*   *",   // B
            "*    ",   // C
            "*   *",   // D
            "*****",   // E
            "*    ",   // F
            " *** ",   // G
            "*   *",   // H
            "  *  ",   // I
            "  *  ",   // J
            "*   *",   // K
            "*    ",   // L
            "*   *",   // M
            "*   *",   // N
            " *** ",   // O
            "*   *",   // P
            " *** ",   // Q
            "*   *",   // R
            " *** ",   // S
            "  *  ",   // T
            "*   *",   // U
            "*   *",   // V
            "*   *",   // W
            "*   *",   // X
            "  *  ",   // Y
            "*****"    // Z
        };
        foreach (char letter in name.ToUpper())
        {
            if (letter >= 'A' && letter <= 'Z')
            {
                int index = letter - 'A';
                Console.WriteLine(starPatterns[index]);
            }
            else
            {
                Console.WriteLine("Invalid character: " + letter);
            }
        }
    }
}
