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

class Solution
{

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q)
    {
        int minSwaps = 0;
        bool TooChaotic = false;
        for (int i = q.Length - 1; i >= 0; i--)
        {
            if (q[i] - (i + 1) > 2)
            {
                //Console.WriteLine("Chaotic check " + (i) + " " + q[i] + " absolute value = " + Math.Abs(i-q[i]) );
                Console.WriteLine("Too chaotic");
                TooChaotic = true;
                break;
            }
            for (int j = Math.Max(0, q[i] - 2); j < i; j++)
            {
                //Console.WriteLine("Swapcheck " + (i) + " " + q[i] + " absolute value = " + Math.Abs(i-q[i]) );
                if (q[j] > q[i]) { minSwaps++; }
            }
        }

        if (TooChaotic == false) { Console.WriteLine(minSwaps); }


    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
            ;
            minimumBribes(q);
        }
    }
}
