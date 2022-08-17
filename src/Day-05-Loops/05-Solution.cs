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

    ///<summary>
    /// Method <c>printTenMutliples</c> takes in an integer from 2 to 20 inclusive and prints its first 10 multiples (1-10)
    ///</summary>
    public static void printTenMutliples(int input)
    {
        for (int i = 1; i <=10; i++)
        {
            int result = input * i;
            Console.WriteLine($"{input} x {i} = {result}.");
        }
    }

    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        printTenMutliples(n);
    }
}
