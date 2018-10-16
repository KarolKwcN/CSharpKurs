
using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = args[0];
            
            //Console.WriteLine("Witaj w swiecie");
            foreach(var item in args)
            {
                Console.WriteLine("Witaj " + item);
            }
        }
    }
}
