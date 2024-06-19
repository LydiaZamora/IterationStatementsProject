using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                
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
