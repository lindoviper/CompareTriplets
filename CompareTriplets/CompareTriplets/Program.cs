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

    // Complete the compareTriplets function below.
    static List<int> compareTriplets(List<int> a, List<int> b)
    {
        var aliceScore = 0;
        var bodScore = 0;


        var alice = new Tuple<int, int, int>(a[0], a[1], a[2]);
        var bob = new Tuple<int, int, int>(b[0], b[1], b[2]);

        if (alice.Item1 > bob.Item1)
        {
            aliceScore++;
        }
        else if (bob.Item1 > alice.Item1)
        {
            bodScore++;
        }

        if (alice.Item2 > bob.Item2)
        {
            aliceScore++;
        }
        else if (bob.Item2 > alice.Item2)
        {
            bodScore++;
        }
        if (alice.Item3 > bob.Item3)
        {
            aliceScore++;
        }
        else if (bob.Item3 > alice.Item3)
        {
            bodScore++;
        }

        return new List<int> { aliceScore, bodScore };
    }

    static void Main(string[] args)
    {

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = compareTriplets(a, b);

        Console.WriteLine(String.Join(" ", result));

    }
}
