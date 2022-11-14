/*
    Leetcode problem 383

    Given two strings ransomNote and magazine, return true if ransomNote can be constructed
    by using the letters from magazine and false otherwise.

    Each letter in magazine can only be used once in ransomNote.
*/

public static class RansomNoteSolution {

    public static string[] notes = {"a", "aa", "aa", "fihjjjjei"};
    public static string[] mags = {"b", "ab", "aab", "hjibagacbhadfaefdjaeaebgi"};

    public static void Test() {

        for (int i = 0; i < notes.Length; ++i)
        {
            Console.WriteLine("Note = " + notes[i] + "\tmagazine = " + mags[i] + 
                "\toutput: " + CanConstruct(notes[i], mags[i]));
        }
    }

    public static bool CanConstruct(string ransomNote, string magazine) {

        if (ransomNote.Length > magazine.Length)
            return false;

        char[] note = ransomNote.ToCharArray();
        char[] mag = magazine.ToCharArray();
        Array.Sort(note);
        Array.Sort(mag);

        // Console.WriteLine("note: " + note.Length + ", mag: " + mag.Length);

        int i, j;

        for (i = 0, j = 0; i < note.Length && j < mag.Length; )
        {
            // Console.WriteLine("note[" + i + "] = " + note[i]);
            // Console.WriteLine("mag[" + j + "] = " + mag[j]);
            if (note[i] == mag[j])
            {
                ++i;
                ++j;
            }

            else
            {
                ++j;
                
            }
        }

        return (i == note.Length);
    }

}