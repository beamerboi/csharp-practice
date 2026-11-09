
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < identifier.Length; i++)
        {
            char c = identifier[i];

            if (c == ' ')
            {
                result.Append('_');
            }
            else if (char.IsControl(c))
            {
                result.Append("CTRL");
            }
            else if (c == '-')
            {
                if (i + 1 < identifier.Length)
                {
                    result.Append(char.ToUpperInvariant(identifier[++i]));
                }
            }
            else if (c >= 'α' && c <= 'ω')
            {
                continue;
            }
            else if (char.IsLetter(c) || c == '_')
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }
}
