using System.IO;
using System;

class Solution
{
    // Complete the circularArrayRotation function below.

    static int[] circularArrayRotation(int[] a, int k, int[] queries)
    {
        int length = a.GetLength(0);

        int position;
        int[] result = new int[queries.GetLength(0)];
        for (int index = 0; index < queries.Length; index++)
        {
            position = queries[index] - k;
            if (position < 0)
                position = position % length + (position % length == 0 ? 0 : length);

            result[index] = a[position];
        }

        return result;
    }


    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("OUTPUT2.TXT", true);

        string[] nkq = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nkq[0]);
        int k = Convert.ToInt32(nkq[1]);
        int q = Convert.ToInt32(nkq[2]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

        int[] queries = new int[q];

        for (int i = 0; i < q; i++)
        {
            int queriesItem = Convert.ToInt32(Console.ReadLine());
            queries[i] = queriesItem;
        }

        int[] result = circularArrayRotation(a, k, queries);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
