namespace BetweenTwoSets;

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
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
        int min = b.Min();
        int max = a.Max();

        int countFactorsOfAandB = 0;
        bool allAreFactorsOfA = false;
        bool allBAreFactorOfIntegerConsidered = false;
        for (int integerConsidered = max; integerConsidered <= min; integerConsidered++)
        {

            // e fator de a
            int aCount = 0;
            allAreFactorsOfA = false;
            allBAreFactorOfIntegerConsidered = false;
            foreach (int elementA in a)
            {
                if (integerConsidered % elementA == 0)
                {
                    aCount++;
                }
            }
            if (aCount == a.Count())
            {
                allAreFactorsOfA = true;
            }


            // b e divisor dele
            int bCount = 0;
            foreach (int elementB in b)
            {
                if (elementB % integerConsidered == 0)
                {
                    bCount++;
                }
            }
            if (bCount == b.Count())
            {
                allBAreFactorOfIntegerConsidered = true;
            }

            if (allAreFactorsOfA && allBAreFactorOfIntegerConsidered)
            {
                countFactorsOfAandB++;
            }
        }        

        return countFactorsOfAandB;
    }

    class Solution
    {
        public static void Main(string[] args)
        {

            string[] firstMultipleInput = "2 3".TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = "2 4".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = "16 32 96".TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            int total = Result.getTotalX(arr, brr);

            Console.WriteLine(total);

        }
    }

}