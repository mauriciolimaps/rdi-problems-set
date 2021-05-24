namespace problem_3
{
    using System;
    using System.IO;
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;
 

    class Result
    {
        // Complete the 'pickingNumbers' function below.

        public static int pickingNumbers(List<int> a)
        {
            List<List<int>> lists;

            lists = new List<List<int>>();
            foreach (int item in a)
            {
                IEnumerable<int> intersection = a.Intersect(new List<int> { item, item + 1 });
                IEnumerable<int> sublist = a.Where(aitem => intersection.Contains(aitem));
                if (sublist.Count() > 1)
                    lists.Add(sublist.ToList<int>());
            }

            int result = (lists.Count() == 0) ? 0 : lists.Max(item => item.Count());

            return result;
        }
    }


    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter("OUTPUT3.TXT", true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = Result.pickingNumbers(a);
            if (result != 0) {
                textWriter.WriteLine(result);
            }
            else
            {
                textWriter.WriteLine("The list doesn't have required conditions");
            }
            
            textWriter.Flush();
            textWriter.Close();
        }
    }
}
