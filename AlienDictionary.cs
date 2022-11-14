/*
    Leetcode proglem 953 - Verifying an Alien Dictionary (Easy)

    In an alien language, surprisingly, they also use English lowercase letters,
    but possibly in a different order.
    The order of the alphabet is some permutation of lowercase letters.

    Given a sequence of words written in the alien language, and the order of the alphabet,
    return true if and only if the given words are sorted lexicographically in this alien language.

*/
public class AlienDictionary {


    public void Test() {

        for (var i = 0; i < TestItems.Length; ++i)
        {
            Console.WriteLine("Result for " + Util.PrintArray(TestItems[i])
                + ", " + Orders[i] +  " = " + IsAlienSorted(TestItems[i], Orders[i]));
        }
    }

    public string[][] TestItems = { new string[]{"hello", "leetcode"},
                                    new string[]{"word", "world", "row"},
                                    new string[]{"apple", "app"} };

    public string[] Orders = {"hlabcdefgijkmnopqrstuvwxyz", "worldabcefghijkmnpqstuvxyz", "abcdefghijklmnopqrstuvwxyz"};

    public bool IsAlienSorted(string[] words, string order) {

        if (words.Length == 1) return true;

        for (int i = 1; i < words.Length; ++i)
            if (order.IndexOf(words[i][0]) < order.IndexOf(words[i - 1][0]))
                return false;

        return true;

    }
}