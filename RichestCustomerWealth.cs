/*

    Leetcode problem 1672

    You are given an m x n integer grid accounts where accounts[i][j] is the amount of money 
    the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. Return the wealth that the richest customer has.

    A customer's wealth is the amount of money they have in all their bank accounts.
    The richest customer is the customer that has the maximum wealth.

*/

using System;

public static class RichestCustomerWealth {


    public static void Test() {
        foreach(int[][] item in TestItems)
        {
            Console.WriteLine("Result for " + PrintDoubleArray(item) + " = " + MaxiumumWealth(item));
        }
    }


    public static int[][][] TestItems = {

        new int[2][]{ new int[3]{1,2,3}, new int[3]{3,2,1}},
        new int[3][]{ new int[2]{1,5}, new int[2]{7,3}, new int[2]{3,5}},
        new int[3][]{ new int[3]{2,8,7}, new int[3]{7,1,3}, new int[3]{1,9,5}}
    };

    public static int MaxiumumWealth(int[][] accounts) {

        int max = 0;
        int cur = 0;

        for (int i = 0; i < accounts.Length; ++i)
        {
            for (int j = 0; j < accounts[i].Length; ++j)
            {
                cur += accounts[i][j];
            }

            max = Math.Max(cur, max);
            cur = 0;
        }

        return max;
    }

    public static int ArraySum(int[] a) {

        int sum = 0;

        for (int i = 0; i < a.Length; ++i)
            sum += a[i];

        return sum;
    }

    public static string PrintArray(int[] a) {

        string result = "[";

        for (int i = 0; i < a.Length - 1; ++i)
            result += (a[i] + ", ");

       result += (a[a.Length - 1] + "]");

        return result;
    }

    public static string PrintDoubleArray(int[][] a) {

        string result = "[";

        for (int i = 0; i < a.Length - 1; ++i)
            result += (PrintArray(a[i]) + ", ");

       result += (PrintArray(a[a.Length - 1]) + "]");

        return result;
    }
}