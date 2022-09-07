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

    public class CustomNumber
    {
        public CustomNumber(int input)
        {
            int decimalRepresentation = input;
            string binaryRepresentation = Convert.ToString(decimalRepresentation, 2); // UNDONE cast binary
            int maxConsecutiveOnesInBinaryRepresentation = GetMaxConsecutiveOnes(binaryRepresentation);
        }

        public static int GetMaxConsecutiveOnes(string binaryNumber)
        {
            string [] arrayOfSpans = binaryNumber.Split("0");

            int maxSpan = 0;

            for (int binarySpan = 0; binarySpan < arrayOfSpans.Length; binarySpan++)
            {
                int lengthOfCurrentSpan = arrayOfSpans[binarySpan].Length;
                
                if (maxSpan < lengthOfCurrentSpan)
                {
                    maxSpan = lengthOfCurrentSpan;
                }
            }

            return maxSpan;
        }

        public static void PrintMaxConsecutiveOnesInBinaryRepresentation()
        {
            Console.WriteLine(maxConsecutiveOnesInBinaryRepresentation);
        }
    }

    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        CustomNumber num = new CustomNumber(n);

        num.PrintMaxConsecutiveOnesInBinaryRepresentation();

    }
}
