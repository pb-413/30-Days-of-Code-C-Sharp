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
     * Complete the 'solve' function below.
     *
     * The function accepts following parameters:
     *  1. DOUBLE meal_cost
     *  2. INTEGER tip_percent
     *  3. INTEGER tax_percent
     */

    public static void solve(double meal_cost, int tip_percent, int tax_percent)
    {
        
        bool debug = true;
        
        // calc tip 

        double tip_cost = ((tip_percent/100) * meal_cost); 

        if (debug)
        {

            Console.WriteLine("DEBUG:" + double.Parse(tip_cost))

        }

        // calc tax 

        double tax_cost = ((tax_percent/100) * meal_cost); 

        if (debug)
        {

            Console.WriteLine("DEBUG:" + double.Parse(tax_cost))

        }

        // clac total 

        double total_cost = meal_cost + tip_cost + tax_cost; 

        // print, rounding to the nearest int

        Console.WriteLine("{0:0}",total_cost);

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

        int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

        int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

        Result.solve(meal_cost, tip_percent, tax_percent);
    }
}
