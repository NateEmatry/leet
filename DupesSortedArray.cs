/*
    Leetcode problem 26

    Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place
    such that each unique element appears only once. The relative order of the elements should be kept the same.

    Since it is impossible to change the length of the array in some languages, you must instead
    have the result be placed in the first part of the array nums.
    More formally, if there are k elements after removing the duplicates,
    then the first k elements of nums should hold the final result.
    It does not matter what you leave beyond the first k elements.

    Return k after placing the final result in the first k slots of nums.

    Do not allocate extra space for another array. You must do this by modifying the input array
    in-place with O(1) extra memory.

*/

public static class DupesSortedArraySolution {

    public static void Test() {

        foreach(int[] t in TestItems)
        {
            Console.WriteLine("Result for " + PrintArray(t) + " = " + RemoveDuplicates(t));
        }
    }

    public static int[][] TestItems = { new int[2]{1, 1}, new int[3]{1, 1, 2}, new int[10]{0,0,0,1,1,2,2,3,3,4} };


    public static int RemoveDuplicates(int[] nums) {

        if (nums.Length == 1)
            return 1;

        int temp = 0;
        int i = 1;

        for (; i < nums.Length && nums[i] != -999; ++i)
        {
            while (nums[i] == nums[i - 1])
            {
                temp = nums[i];
                for (int j = i; j < nums.Length - 1; ++j)
                    nums[j] = nums[j + 1];

                nums[nums.Length - 1] = -999;

            }

        }

        return i;
    }

    public static string PrintArray(int[] a) {

        string result = "[";

        for (int i = 0; i < a.Length - 1; ++i)
            result += (a[i] + ", ");

       result += (a[a.Length - 1] + "]");

        return result;
    }
}