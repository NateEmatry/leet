/*
    Leetcode problem 1047

    You are given a string s consisting of lowercase English letters.
    A duplicate removal consists of choosing two adjacent and equal letters and removing them.

    We repeatedly make duplicate removals on s until we no longer can.

    Return the final string after all such duplicate removals have been made.
    It can be proven that the answer is unique.

*/

using System.Text;

public static class RemoveAdjacentSolution {

    public static void Test() {

        foreach(string s in TestItems)
        {
            Console.WriteLine("Result for " + s + " = " + RemoveDuplicates(s));
        }
    }

    public static string[] TestItems = { "abbaca", "azxxzy"};

    public static string RemoveDuplicates(string s) {

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < s.Length; ++i)
        {
            if (sb.Length > 0 && s[i] == sb[sb.Length - 1])
                sb.Length = sb.Length - 1;
            else
                sb.Append(s[i]);
        }

        return sb.ToString();
    }
}