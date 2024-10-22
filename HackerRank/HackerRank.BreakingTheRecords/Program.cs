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

namespace HackerRank.BreakingTheRecords;

class Result
{

    /*
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {

        int minRecordsBreaks = 0;
        int maxRecordsBreaks = 0;

        int min = scores[0];
        int max = scores[0];

        for(int i  = 1; i < scores.Count; i++)
        {
            if(scores[i] < min)
            {
                min = scores[i];
                minRecordsBreaks++;
            }

            if (scores[i] > max)
            {
                max = scores[i];
                maxRecordsBreaks++;
            }

        }        

        return new[] { maxRecordsBreaks, minRecordsBreaks }.ToList();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32("9".Trim());

        List<int> scores = "10 5 20 20 4 5 2 25 1".TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        Console.WriteLine(String.Join(" ", result));
    }
}
