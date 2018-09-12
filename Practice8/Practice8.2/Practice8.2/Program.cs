using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array;
namespace Practice8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Massiv mas = new Massiv(10);
            Random random = new Random();
            for (int i = 0; i < mas.Size; i++)
            {
                mas[i] = random.Next(5, 20);
            }
            Console.Write("Массив: ");
            for (int i = 0; i < mas.Size; i++)
            {
                Console.Write(mas[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
