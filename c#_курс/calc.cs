using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
           
           
            Console.WriteLine("Введите количество операций");
          int b = int.Parse(Console.ReadLine());
                
           for(; i<b; i++)
            {
                Console.WriteLine("Выберите операцию" +
               "1) сложение" +
               "2) вычитание" +
               "3)умножение" +
               "4)деление");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество слагаемых");
                int s = int.Parse(Console.ReadLine());
                int ch = 0;
                for (int g = 0; g < s; g++)
                {
                   
                    Console.WriteLine("введите число");
                    
                   int chislo1 = int.Parse(Console.ReadLine());
                    ch += chislo1;
                    
                    

                }
                Console.WriteLine("сумма равна" + ch);
                /*switch (a)
                {
                   
                    
                    case 1:
                    {
                    int c = chislo1 + chislo2;
                    Console.WriteLine("сумма равна" + c);
                            c += c;
                            Console.WriteLine("сумма равна" + c);
                            break;
                    }

                }*/
            }

        }
    }
}
