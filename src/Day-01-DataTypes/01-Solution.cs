using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        int integerTwo; 
        double doubleTwo; 
        string stringTwo; 
        // Read and save an integer, double, and String to your variables.
        integerTwo = int.Parse(Console.ReadLine());
        doubleTwo = double.Parse(Console.ReadLine()); 
        stringTwo = Console.ReadLine();
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + integerTwo);
        Console.WriteLine("{0:0.0}", d + doubleTwo);
        Console.WriteLine(s + stringTwo);
        // Print the sum of the double variables on a new line.
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.

    }
}