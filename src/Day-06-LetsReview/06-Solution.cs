/*

Constraints
- T - #of test cases ranges from 1 to 10 
- S - strings to process range in length from 2 to 10000

*/


using System;
using System.Collections.Generic;
using System.IO;
class Solution {

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

    public static void printEvenThenOddCharacters(string input)
    {
        //build string(s) w/ loop + if-else

        string evens = "", odds = ""; 

        for (int characterPosition = 0; characterPosition < input.Length; characterPosition++)
        {
            
            if (isOdd(characterPosition))
            {
                odds += input[characterPosition];
            }
            else
            {
                evens += input[characterPosition];
            }
        }

        //print string(s)

        Console.WriteLine($"{evens} {odds}");

    }

    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int num_test_cases=int.Parse(Console.In.ReadLine());
        for (int i = 0; i < num_test_cases; i++) {
            string str=Console.In.ReadLine();

            printEvenThenOddCharacters(str);

        }
    
    }
}