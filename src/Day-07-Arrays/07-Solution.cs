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

/*

Constraints 

N - Number of elements in the array ranges from 1 to 1000

A[i] - the ith element of the array ranges from 1 to 10000

*/

class Solution
{

    public static void printReverse(List<int> input)
    {
        
        for(int itemPosition = 0; itemPosition < input.Count(); itemPosition++)
        {
            //Constole.WriteLine(input.RemoveAt(-1));
            Console.WriteLine(input[itemPosition]);
        }
        
    }

    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        printReverse(arr);
    }
}
