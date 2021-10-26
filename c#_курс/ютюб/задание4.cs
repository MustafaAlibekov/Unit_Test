using System;
using System.Globalization;
namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());
            if(a % 2 ==0)
            {
                Console.WriteLine("Число четное");
                    }
            else
            {
                Console.WriteLine("Число нечетное");
            }
        }
    }
}
