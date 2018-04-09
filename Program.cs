using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            //count up
            for (i = 0; i <= 10; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                    
                }
                if (i > 0 & (i * 2) % 2 == 0)
                {
                   Console.Write(i * 2);
                }
             Console.WriteLine();
           }

            Console.WriteLine();
            
            //count down 
            for (i = 10; i >= 0; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
                if (i > 0 & (i * 2) % 2 == 0)
                {
                    Console.Write(i * 2);
                }
                Console.WriteLine();
            }
        }
    }
}
