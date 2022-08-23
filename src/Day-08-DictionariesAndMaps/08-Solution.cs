using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    
    public static void queryPhonebook(string query, Dictionary phonebook)
    {
        Console.WriteLine(phonebook[query]);

        //TODO process null return (i'm guessing)
    }
    
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        
        /*Read in N, the number of phonebook entries*/

        int numEntries = int.Parse(Console.In.ReadLine());
        
        
        /*Read in N # of entries and create the phonebook*/

        Dictionary<string,int> phonebook;

        for (int i = 0; i < numEntries; i++) 
        {
            //TODO process input and prepare for entry into phonebook (dict)
            
            phonebook.Add();
        }

        
        /*Read in quieries for the phonebook and return results*/

        //TODO while there is still input
        string query = ""; //TODO parse input
        queryPhonebook(query, phonebook);
    
    }
}