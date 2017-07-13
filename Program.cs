using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List <double> randomNum = new List <double>();
            
            for( var j = 0; j < 20; j++)
            {
                randomNum.Add(random.Next(1, 50));
            }

            List <double> squared = new List <double>();   

            List<double> filtered = new List <double>();   


            //random numbers
            Console.WriteLine("\nRando Numbers\n");
            
            foreach(double num in randomNum)
            {
                Console.WriteLine(num);
                squared.Add(num * num);
            }
            
            //squared numbers
            Console.WriteLine("\nSquared Numbers\n");
            
            foreach(double sq in squared)
            {
                Console.WriteLine(sq);
            }
            //remove odd numbers
            Console.WriteLine("\nRemove Odd Numbers\n");
            
            foreach(double sq in squared)
            {
                if(sq % 2 == 0)
                {
                    Console.WriteLine(sq);
                }
            }

        
        }
    }
}
