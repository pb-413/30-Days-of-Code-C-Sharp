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

enum Weirdness
{
    StartWeirdness,
    Weird,
    NotWeird,
    EndWeirdness
}

class OutOfProblemBoundsException : Exception
{
    public OutOfProblemBoundsException(string message)
    {
    }
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
            throw new OutOfProblemBoundsException("getWeridness could not resolve to expected output");
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
    /// Method <c>printWeirdness</c> takes in an integer from 1 to 100 inclusive
    ///</summary>
    public static void printWeirdness(int input)
    {
        
        Weirdness resultWeirdness;

        if (isOdd(input) & 1 <= input)
        {
            //Odd is weird
            resultWeirdness = Weirdness.Weird;
        }
        else if (2 <= input & input <= 5)
        {
            //This range is not weird
            resultWeirdness = Weirdness.NotWeird;
        }
        else if (6 <= input & input <=20)
        {
            //This range is weird
            resultWeirdness = Weirdness.Weird;
        }
        else if (21 <= input & input <=100)
        {
            //This range is not weird
            resultWeirdness = Weirdness.NotWeird;
        }
        else
        {
            throw new OutOfProblemBoundsException("input for printWeirdness is out of expected range (1-100)");
            resultWeirdness = Weirdness.EndWeirdness;
        }

        Console.WriteLine(Result.getWeirdness((int)resultWeirdness));
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
