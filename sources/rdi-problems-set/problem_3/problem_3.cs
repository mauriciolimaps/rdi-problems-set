namespace problem_3
{
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Text.RegularExpressions;
    using System.Text;
    using System;

    class Result
    {

        // Complete the 'pickingNumbers' function below.

        public static int pickingNumbers(List<int> a)
        {


            return 0;
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

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
