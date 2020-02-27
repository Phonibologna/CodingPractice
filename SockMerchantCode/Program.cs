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

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {
        int pairs = 0;
        int[] ar2 = new int[ar.Length];
        //Doing this because I didn't want to mess with the original array
        Array.Copy(ar, ar2, ar.Length);
        //bubblesort was the first thing that came to mind.
        for (int i = 0; i < ar2.Length; i++)
        {
            if (ar2[i] != -1)
            {
                for (int j = 0; j < ar2.Length; j++)
                {
                    if (ar2[j] != -1)
                    {
                        if (ar2[i] == ar2[j] && i != j)
                        {
                            pairs++;
                            ar2[i] = -1;
                            ar2[j] = -1;
                            break;
                        }
                    }
                }
            }
        }
        return pairs;



    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

