using System;
using System.Linq;

namespace WheelArray.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = Enum.GetValues(typeof(Months)).Cast<Months>();

            var ar = new WheelArray<Months>(values.ToArray());

            ar.SetStart(1);
            //foreach(var a in ar)
            //{
            //    Console.WriteLine($"{a}: {(int)a}");
            //}

            foreach(var i in new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 })
            {
                Console.WriteLine($"{ar[i]}: {i}");
            }

            Console.WriteLine("Hello World!");
        }
    }


    enum Months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }
}
