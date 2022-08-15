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

enum weirdness
{
    Weird = "Weird",
    NotWeird = "Not Weird"

}

class Result
{
    public static bool isOdd(int input)
    {
        if (input % 2 == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    ///<summary>
    /// Method <c>isWeird</c> takes in an integer from 1 to 100 inclusive
    ///</summary>
    public static void isWeird(int input)
    {
        if (isOdd(input))
        {
            //Odd is weird
            Console.WriteLine(weirdness.Weird);
        }
        else if (2 <= input & input <= 5)
        {
            //This range is not weird
            Console.WriteLine(weirdness.NotWeird);
        }
        else if (/*TODO*/)
        {
            //This range is not weird
            Console.WriteLine(weirdness.NotWeird);
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());
    }
}
