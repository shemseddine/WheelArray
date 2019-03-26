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
            foreach(var a in ar)
            {
                Console.WriteLine($"{a}: {(int)a}");
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
