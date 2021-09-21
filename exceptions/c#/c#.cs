using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            try
            {
                Console.WriteLine("Введите первое число: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите второе число: ");
                b = Convert.ToDouble(Console.ReadLine());

                if (b == 0)
                    Console.WriteLine("Деление на 0 невозможно");
                else
                    Console.WriteLine("Result:" + " " + a / b);

            }
            catch
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine("Размер integer в битах:" + " " + sizeof(int));
            Console.WriteLine("Размер of float в битах:" + " " + sizeof(float));
        }
    }

}
