/*
    Leetcode problem 295 (Hard) Daily Challenge 11-12-2022

    The median is the middle value in an ordered integer list. If the size of the list is even,
    there is no middle value, and the median is the mean of the two middle values.

    For example, for arr = [2,3,4], the median is 3.
    For example, for arr = [2,3], the median is (2 + 3) / 2 = 2.5.

    Implement the MedianFinder class:

    MedianFinder() initializes the MedianFinder object.
    void addNum(int num) adds the integer num from the data stream to the data structure.
    double findMedian() returns the median of all elements so far.
    Answers within 10^(-5) of the actual answer will be accepted.

*/

using System.Collections.Generic;

public class MedianFinder {

    private List<int> arr;
    private int medianIndex;
    private int count;

    public MedianFinder() {

        arr = new List<int>();
        medianIndex = 0;
        count = 0;
        
    }
    
    public void AddNum(int num) {

        if (count == 0 || num > arr.Last())
            arr.Add(num);

        else if (num < arr[0])
            arr.Insert(0, num);

        else
        {
            while (num < arr[medianIndex])
                --medianIndex;

            while(num > arr[medianIndex])
                ++medianIndex;

            arr.Insert(medianIndex, num);
        }
        
        ++count;
        medianIndex = count / 2;
    }
    
    public double FindMedian() {

        // arr.Sort();

        if (count % 2 == 0)
            return (double)( arr[count / 2] + arr[(count / 2) - 1]) / 2.0;

        return (double)(arr[count / 2]);

    }

    public void PrintArray() {

        string result = "[";

        for (int i = 0; i < arr.Count - 1; ++i)
            result += (arr[i] + ", ");

        result += (arr[arr.Count - 1] + "]");

        Console.WriteLine(result);
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */