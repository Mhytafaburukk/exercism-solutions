using System;
using System.Text;

public static class CryptoSquare
{
    public static string Ciphertext(string plaintext)
    {
        StringBuilder cleanSb = new StringBuilder();
        foreach (char ch in plaintext)
        {
            if (char.IsLetterOrDigit(ch))
            {
                cleanSb.Append(char.ToLower(ch));
            }
        }
        string lastWord = cleanSb.ToString();

        if (string.IsNullOrEmpty(lastWord))
            return "";

        int length = lastWord.Length;
        int c = (int)Math.Ceiling(Math.Sqrt(length));
        int r = (int)Math.Ceiling((double)length / c);

        string[] words = new string[r];
        int baslangic = 0;

        for (int i = 0; i < r; i++)
        {
            if (baslangic + c <= length)
            {
                words[i] = lastWord.Substring(baslangic, c);
            }
            else
            {
                string kalan = lastWord.Substring(baslangic);
                words[i] = kalan.PadRight(c, ' ');
            }
            baslangic += c;
        }

        StringBuilder sb2 = new StringBuilder();

        for (int col = 0; col < c; col++)
        {
            if (col > 0)
            {
                sb2.Append(" ");
            }

            for (int row = 0; row < r; row++)
            {
                sb2.Append(words[row][col]);
            }
        }

        return sb2.ToString();
    }
}
