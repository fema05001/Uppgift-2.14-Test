using System;

namespace Uppgift_2_14
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string x =Console.ReadLine();
            string y = Console.ReadLine();
            float a =float.Parse(x);
            float b = float.Parse(y);
            Console.Write("svaret blir");
            Console.Write(a * b);
        }
    }
}