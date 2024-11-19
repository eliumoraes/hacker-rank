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

    /*
     * Complete the 'divisibleSumPairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     *  3. INTEGER_ARRAY ar
     */

    public static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        int divisibleCount = 0;


        for (int i = 0; i < n-1; i++)
        {
            for(int j = i + 1; j < n; j++)
            {
                int a = ar[i];
                int b = ar[j];
                if ((a + b) % k == 0)
                {
                    divisibleCount++;
                }
            }
        }

        return divisibleCount;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = "6 3".TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> ar = "1 3 2 6 1 2".TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.divisibleSumPairs(n, k, ar);

        Console.WriteLine(result);

        Console.ReadLine();
    }
}
