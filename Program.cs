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
            
            Console.WriteLine("\nTwenty Rando Numbers\n");
            
            foreach(double num in randomNum)
            {
                Console.WriteLine(num);
            }


        
        }
    }
}
