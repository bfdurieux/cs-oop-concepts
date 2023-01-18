namespace ConsoleApp1.Problems;

public static class StringReversal
{
    public static void ReverseString(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            Console.WriteLine("Given string was empty.");
            return;
        }

        var reversed = str.ToCharArray();
        Array.Reverse(reversed);
        Console.WriteLine(new string(reversed));
    }

    public static void ReverseWordOrder(string sentence)
    {
        var words = sentence.Split(' ');
        Array.Reverse(words);
        Console.WriteLine(string.Join(" ", words));
    }

    public static bool IsPalindrome(string word)
    {
        if (word.Contains(' '))
            throw (new Exception("Word should not contain white spaces."));

        var reversed = word.ToLower().ToCharArray();
        Array.Reverse(reversed);

        return new string(reversed).Equals(word.ToLower());
    }
}