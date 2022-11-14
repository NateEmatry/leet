/*
    Leetcode problem 1

    Given an array of integers nums and an integer target, return indices of the two numbers such that
        they add up to target.
    You may assume that each input would have exactly one solution, and you may not use the same element twice.
    You can return the answer in any order.
*/

public static class TwoSumSolution {

    public static void Test() {

        foreach((int[], int) t in TestItems)
        {
            Console.WriteLine("Result for " + PrintArray(t.Item1) +
                ", " + t.Item2 +  " = " + PrintArray(TwoSum(t.Item1, t.Item2)));
        }
    }

    static int[] test1 = {3, 2, 4};

    public static (int[], int)[] TestItems = {(test1, 6)};

    public static int[] TwoSum(int[] nums, int target) {

        for (int i = 0; i < nums.Length - 1; ++i)
            for (int j = i + 1; j < nums.Length; ++j)
                if (nums[i] + nums[j] == target)
                    return new int[2] {i, j};


        return new int[2];
    }

    public static string PrintArray(int[] a) {

        string result = "[";

        for (int i = 0; i < a.Length - 1; ++i)
            result += (a[i] + ", ");

       result += (a[a.Length - 1] + "]");

        return result;
    }
}