/*
    Leetcode problem 151 - Reverse Words in a String (Medium)
    Daily Challenge 11-13-2022

    Given an input string s, reverse the order of the words.

    A word is defined as a sequence of non-space characters. The words in s will be separated
    by at least one space.

    Return a string of the words in reverse order concatenated by a single space.

    Note that s may contain leading or trailing spaces or multiple spaces between two words.
    The returned string should only have a single space separating the words. Do not include any extra spaces.

*/

using System.Text;
using System.Text.RegularExpressions;

public class ReverseWordsSolution {


    public void Test() {

        foreach(string s in TestItems)
        {
            Console.WriteLine("Result for " + s + " = " + ReverseWords(s));
        }
    }

    public string[] TestItems = {"  hello world  ", "a good   example",};

    public string ReverseWords(string s) {

        // StringBuilder sb = new StringBuilder();
        // Regex r = new Regex(@"\s+");
        // string[] words = r.Split(s.Trim());
        // sb.AppendJoin(' ', words.Reverse());

        // return sb.ToString();

        return new StringBuilder().AppendJoin(' ', new Regex(@"\s+").Split(s.Trim()).Reverse()).ToString();
    }
}