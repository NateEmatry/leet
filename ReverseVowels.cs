// Leetcode problem 345

using System.Text;

public static class ReverseVowelsSolution {

    public static void Test() {

        foreach(string s in TestItems)
        {
            Console.WriteLine("Result for " + s + " = " + ReverseVowels(s));
        }
    }

    public static string[] TestItems = {"aediou", "AEIOU", "lEeTcOdE", "hello"};

    public static string ReverseVowels(string s) {

        char[] vowelSet = {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        StringBuilder sb = new StringBuilder();

        int near = 0, far = s.Length - 1;
        char[] reversed = new char[s.Length];

        while (near <= far)
        {
            if (vowelSet.Contains(s[near]))
            {
                while (!vowelSet.Contains(s[far]))
                {
                    reversed[far] = s[far];
                    --far;
                }

                reversed[near] = s[far];
                reversed[far] = s[near];

                --far;
                ++near;
            }

            else
            {
                reversed[near] = s[near];
                ++near;
            }
        }

        for (int i = 0; i < reversed.Length; ++i)
            sb.Append(reversed[i]);


        string result = sb.ToString();
        
        return result;
    }
}