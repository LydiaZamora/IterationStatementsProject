using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                
            
            //-----START HERE------------------------------------------
            

            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
                // in your initializer set the value of i to 199
                // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
                // AND as long as i is greater than or equal to 0
                // Decrement i by 1

            //start for loop here
            {
                // place numbers[i] inside of the Console.WriteLine() method
            }

            //------------End of exercise



            var numbers = new List<int>();

            var myNumber = 0;

            //------do while loop-----

            do
            {
                myNumber++;

                numbers.Add(myNumber);

            } while (myNumber < 100);


            //------ while loop-------

            while (myNumber<200)
            {
                myNumber++;

                numbers.Add(myNumber);

            }

            //----foreach loop--------
            Console.WriteLine("Increase");

            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("");
            Console.WriteLine("Decrease");



            //-----for loop------------

            for(int i = 199; i <= numbers.Count && i >=0; i--)
            {
                Console.WriteLine($"{numbers[i]}");
            }
        }

    }
}
