using System;
using System.Globalization;
namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*вводим количество чисел и конверируем строковый тип в числовой(ToInt32)*/
            Console.WriteLine("Ведите количество чисел");
            int n =Convert.ToInt32 (Console.ReadLine());
            double s = 0;//s-сумма чисел
            for (int i = 1; i<=n; i++)//начинаем цикл for
            {
                Console.WriteLine($"write {i} number");//просим ввести число, i в данном случаем меняется с началом цикла
                int x=Convert.ToInt32(Console.ReadLine());// снова конвертация строки в числовой тип
                s +=x;//каждый раз к переменной s будет прибавлятся число, вводимое в цикл пользователем
            }
            double result = s/n;//нахождение среднего арифметического
            Console.WriteLine($"Результат {result}");// вывод результата
        }
    }
}
