using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder result = new StringBuilder();
        bool upperCaseNextChar = false;
        foreach (char c in identifier)
        {
            if (c == ' ')
            {
                result.Append('_');
            }
            else if (char.IsControl(c))
            {
                result.Append("CTRL");
            }
            else if (upperCaseNextChar)
            {
                result.Append(char.ToUpper(c));
                upperCaseNextChar = false;
                continue;
            }
            else if (c.Equals('-'))
            {
                upperCaseNextChar = true;
                continue;
            }        
            else if (c.IsGreekLowercase())
            {
                continue;
            }
            else if (char.IsLetter(c))
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }

    private static bool IsGreekLowercase(this char c) => 'α' <= c && c <= 'ω';
}
