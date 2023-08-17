namespace MorningAssignment;

internal class CountCharacters
{
    public int CountCharacter(string input)
    {
        int count = 0;

        foreach (char c in input)
        {
            if (!char.IsWhiteSpace(c)) // Exclude whitespace
            {
                count++;
            }
        }
        return count;
    }
}
