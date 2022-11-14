// Leetcode problem 13

using System.Collections.Generic;

public static class RomanToIntegerSolution {

    public static void Test() {

        foreach(string s in TestItems)
        {
            Console.WriteLine("Result for " + s + " = " + RomanToInt(s));
        }
    }

    public static string[] TestItems = {"III", "MCMXCIV", "MMMCDXLIX"};

    public static int RomanToInt(string s) {

        int result = 0;
        char c, p;
        s = "Z" + s;

        for (int i = 1; i < s.Length; ++i)
        {
            c = s[i];
            p = s[i - 1];

            if (c =='I')
                result += 1;

            else if (c =='V')
                result += (p =='I') ? 3 : 5;

            else if (c =='X')
                result += (p == 'I') ? 8 : 10;

            else if (c == 'L')
                result += (p == 'X') ? 30 : 50;

            else if (c =='C')
                result += (p == 'X') ? 80 : 100;

            else if (c == 'D')
                result += (p == 'C') ? 300 : 500;

            else if (c == 'M')
                result += (p == 'C') ? 800 : 1000;
            
        }
        
        return result;
    }

   
}