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
    StartWeirdness,
    Weird,
    NotWeird,
    EndWeirdness
}

class Result
{
    public static string getWeirdness(int input)
    {
        if (input == 1)
        {
            return "Weird";
        }
        else if (input == 2)
        {
            return "Not Weird";
        }
        else
        {
            //IDK if this actually works, but here it is
            throw exception;
        }
    }
    
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
    public static void printWeirdness(int input)
    {
        
        int resultWeirdness;

        if (isOdd(input) & 1 <= input)
        {
            //Odd is weird
            resultWeirdness = weirdness.Weird;
        }
        else if (2 <= input & input <= 5)
        {
            //This range is not weird
            resultWeirdness = weirdness.NotWeird;
        }
        else if (6 <= input & input <=20)
        {
            //This range is weird
            resultWeirdness = weirdness.Weird;
        }
        else if (21 <= input & input <=100)
        {
            //This range is not weird
            resultWeirdness = weirdness.NotWeird;
        }
        else
        {
            Console.WriteLine("This is out of bounds for this problem");
            resultWeirdness = weirdness.EndWeirdness;
        }

        Console.WriteLine(Result.getWeirdness(resultWeirdness));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());

        Result.printWeirdness(N);
    }
}
