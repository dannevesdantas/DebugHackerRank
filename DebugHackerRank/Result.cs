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
     * Complete the 'twoStacks' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER maxSum
     *  2. INTEGER_ARRAY a
     *  3. INTEGER_ARRAY b
     */

    public static int twoStacks(int maxSum, List<int> a, List<int> b)
    {
        int topA = 0;
        int topB = 0;

        int sum = 0;
        int removedIntegers = 0;

        while (sum <= maxSum && (topA < a.Count && topB < b.Count))
        {
            if (a[topA] > b[topB])
            {
                Console.WriteLine($"{a[topA]} na stack A eh maior que {b[topB]} na stack B!");
                // Pop from B
                int removedFromB = b[topB++];
                sum += removedFromB;
                if (sum > maxSum) { break; }
                removedIntegers++;
                Console.WriteLine($"Removi {removedFromB} da stack B.");
            }
            else
            {
                Console.WriteLine($"{b[topB]} na stack B eh maior que {a[topA]} na stack A!");
                // Pop from B
                int removedFromA = a[topA++];
                sum += removedFromA;
                if (sum > maxSum) { break; }
                removedIntegers++;
                Console.WriteLine($"Removi {removedFromA} da stack A.");
            }
            Console.WriteLine($"A soma agora eh {sum}/{maxSum} e a qtd de numeros removidos ate entao eh {removedIntegers}.");
        }

        return removedIntegers;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int g = Convert.ToInt32(Console.ReadLine().Trim());

        for (int gItr = 0; gItr < g; gItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            int maxSum = Convert.ToInt32(firstMultipleInput[2]);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            int result = Result.twoStacks(maxSum, a, b);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
