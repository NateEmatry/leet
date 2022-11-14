/*
    Given an integer n, return a string array answer (1-indexed) where:

    answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
    answer[i] == "Fizz" if i is divisible by 3.
    answer[i] == "Buzz" if i is divisible by 5.
    answer[i] == i (as a string) if none of the above conditions are true.

*/

public static class FizzBuzzSolution {

    public static void Test() {

        foreach(int n in TestItems)
        {
            Console.WriteLine("Result for " + n + " = " + PrintList(FizzBuzz(n)));
        }
    }

    public static int[] TestItems = {3, 5, 15};


    public static IList<string> FizzBuzz(int n) {

        string[] nums = new string[n];

        for (int i = 0; i < n; ++i)
            nums[i] = (i + 1).ToString();

        for (int i = 2; i < n; i += 3)
            nums[i] = "Fizz";

        for (int i = 4; i < n; i += 5)
            nums[i] = "Buzz";

        for (int i = 14; i < n; i += 15)
            nums[i] = "FizzBuzz";


        return new List<string>(nums);
    }


    public static string PrintList(IList<string> ls) {

        string result = "";

        for (int i = 0; i < ls.Count - 1; ++i)
            result += ("\"" + ls[i] + "\"" + ", ");

        result += ("\"" + ls[ls.Count - 1] + "\"");

        return result;

    }
}