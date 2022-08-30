using System;
using System.Collections.Generic;
using System.IO;

class Solution {
       
    public static void queryPhonebook(string query, Dictionary<string,int> phonebookDict)
    {

        //C# Documentation more efficient than what I had?
        string value = 0;
        if (phonebookDict.TryGetValue(query,out value))
        {
            Console.WriteLine($"{query}={value}");
        }
        else
        {
            Console.WriteLine("Not found");
        }
                
    }
    
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        
        /*Read in N, the number of phonebook entries*/

        int numEntries = int.Parse(Console.In.ReadLine());
        
        
        /*Read in N # of entries and create the phonebook*/

        Dictionary<string,int> phonebook = new Dictionary<string, int>();

        for (int i = 0; i < numEntries; i++) 
        {
            //TODO process input and prepare for entry into phonebook (dict)
            
            List<string> inputPhoneRecordAsList = Console.ReadLine().TrimEnd().Split(' ').ToList();
            string name = inputPhoneRecordAsList[0];
            int phoneNumber = Convert.ToInt32(inputPhoneRecordAsList[1]);

            phonebook.Add(name, phoneNumber);
        }

        
        /*Read in quieries for the phonebook and return results*/

        //TODO while there is still input
        string query = Console.ReadLine();
        
        while(!string.IsNullOrEmpty(query))
        {
            queryPhonebook(query, phonebook);
            
            query = Console.ReadLine();
        }
    
    }
}