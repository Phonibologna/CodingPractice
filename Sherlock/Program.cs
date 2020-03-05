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

    // Complete the isValid function below.
    static string isValid(string s)
    {
        int min = 0;
        int max = 0;
        int[] alpha = new int[27];
        int tooMany = 0;
        int numOnes = 0;
        int midpoint = 0;

        for (int i = 0; i < 27; i++)
        {
            alpha[i] = 0;
        }

        foreach (char c in s)
        {
            alpha[(int)c % 32] = alpha[(int)c % 32] + 1;
        }

        for (int i = 0; i < 27; i++)
        {
            Console.WriteLine("Element " + i + ": " + alpha[i]);
        }

        for (int i = 0; i < 27; i++)
        {
            if (alpha[i] == 1)
            {
                numOnes++;
            }
        }

        for (int j = 1; j < 27; j++)
        {
            if (alpha[j] != 0)
            {
                if (min == 0 && max == 0)
                {
                    min = alpha[j];
                    max = alpha[j];
                }
                else if (alpha[j] < min)
                {
                    min = alpha[j];
                }
                else if (alpha[j] > max)
                {
                    max = alpha[j];
                }
            }
        }
        for (int j = 1; j < 27; j++)
        {
            if ((alpha[j]) > min && numOnes != 1)
            {
                tooMany++;
            }
            if (alpha[j] > min && alpha[j] < max)
            {
                midpoint++;
            }
        }
        if (numOnes == 1) { tooMany++; }

        if (max - min == 0)
        {
            return "YES";
        }
        else if (max - min == 1 && tooMany < 2)
        {
            return "YES";
        }
        else if (max - min == 1 && numOnes == 1)
        {
            return "YES";
        }
        else if (numOnes == 1 && tooMany < 2 && midpoint == 0)
        {
            return "YES";
        }
        else
        {
            return "NO";
        }

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = isValid(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
