namespace FitnessApp.Services;

public static class NameSoundValidation
{
    private static readonly char[] xmovnebi = "aeiouაეიოუ".ToCharArray();

    public static int CountVowels(this string name)
    {
        var xmovenbi = 0;

        foreach (var c in name.ToLower())
            if (xmovnebi.Contains(c))
                xmovenbi++;

        return xmovenbi;
    }
}