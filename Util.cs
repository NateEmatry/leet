public static class Util {

    public static string PrintArray(int[] a) {

        string result = "[";

        for (int i = 0; i < a.Length - 1; ++i)
            result += (a[i] + ", ");

        result += (a[a.Length - 1] + "]");

        return result;
    }

    public static string PrintArray(string[] a) {

        string result = "[";

        for (int i = 0; i < a.Length - 1; ++i)
            result += (a[i] + ", ");

        result += (a[a.Length - 1] + "]");

        return result;
    }
}