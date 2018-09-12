using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RangeOfArray;
namespace Practice8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Array = new Class1(5,15);
            Random random = new Random();
        for(int i = Array.min; i < Array.max; i++)
            {
                Array[i] = random.Next(0,100);
            }
            Console.Write("Массив: ");
            for (int i = Array.min; i < Array.max; i++)
            {
                Console.Write(Array[i]+" ");
            }
             
            //try
            //{
            //    Array[21] = 43;

            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"Error:{ ex.Message}");
            //}
            Console.ReadLine();
        }
    }
}
