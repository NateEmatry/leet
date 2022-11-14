/*
    Leetcode problem 1342

    Given an integer num, return the number of steps to reduce it to zero.

    In one step, if the current number is even, you have to divide it by 2,
    otherwise, you have to subtract 1 from it.

*/


public static class NumberOfStepsSolution {

    public static void Test() {

        foreach(int n in TestItems)
        {
            Console.WriteLine("Result for " + n + " = " + NumberOfSteps(n));
        }
    }

    public static int[] TestItems = {14, 8, 123};

    public static int NumberOfSteps(int num) {

        int count = 0;

        while (num > 0)
        {
            if (num % 2 == 0)
            {
                num /= 2;
                ++count;
            }

            else
            {
                num -= 1;
                ++count;
            }
        }


        return count;
    }
}