using System;


namespace Playground
{
    class Program
    {

        public static void Main()
        {
            string[] compositeString = { "4for", "2is the", "3week 10 challenge assignment", "1This assignment", "5CIS243" };
            string[] copyString = new string[0];

           Array.Sort(compositeString);

           for (int i = 0; i < compositeString.Length; i++)
           {
               Array.Resize(ref copyString, copyString.Length + 1);
               copyString[copyString.Length - 1] = compositeString[i].Substring(1);
           }
            Console.Write(string.Join(" ", copyString));
            Console.WriteLine();
        }
    }
}


