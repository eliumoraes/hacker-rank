namespace SubarrayDivision;
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
     * Complete the 'birthday' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY s
     *  2. INTEGER d
     *  3. INTEGER m
     */

    public static int birthday(List<int> s, int d, int m)
    {
        if (s.Count == 1)
        {
            if (m == 1 && d == s[0])
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        int counter = 0;
        //   19-7 = 12
        for (int i = 0; i <= s.Count - m; i++)
        {
            int sum = 0;
            //6
            for (int x = 0; x < m; x++ )
            {
                sum += s[x+i];                
            }

            if (sum == d)
            {
                counter++;
            }
        }

        return counter;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        

        int n = Convert.ToInt32("19");

        List<int> s = "2 5 1 3 4 4 3 5 1 1 2 1 4 1 3 3 4 2 1".TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        string[] firstMultipleInput = "18 7".TrimEnd().Split(' ');

        int d = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.birthday(s, d, m);

        Console.WriteLine(result);
        Console.ReadKey();
    }
}
