using System;
using System.Collections.Generic;
using System.IO;

///////////////////Editable Code////////////////////////////////////////////

class Person {
    public int age;     
	public Person(int initialAge) {
        // Add some more code to run some checks on initialAge
        if (0 < initialAge & initialAge <= 30)
        {
            age = initialAge; 
        }
        else if(-5 <= initialAge & initialAge <= 0)
        {
            age = 0;
            Console.WriteLine("Age is not valid, setting age to 0.");
        }
        else
        {
            Console.WriteLine("Out of problem bounds for initialAge (-5 to 30)");
        }
     }
     public void amIOld() {
        // Do some computations in here and print out the correct statement to the console 
        if (age < 13)
        {
            Console.WriteLine("You are young.");
        }
        else if(13 <= age & age <18)
        {
            Console.WriteLine("You are a teenager.");
        }
        else if(age <= 30)
        {
            Console.WriteLine("You are old.");
        }
     }

     public void yearPasses() {
        // Increment the age of the person in here
        age++;
     }

///////////////////Editable Code////////////////////////////////////////////

static void Main(String[] args) {
        int T=int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++) {
            int age=int.Parse(Console.In.ReadLine());
            Person p=new Person(age);
             p.amIOld();
                for (int j = 0; j < 3; j++) {
                  p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
        }
    }
}
