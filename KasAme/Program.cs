using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasAme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение параметра x = ");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            double F = 5 * Math.Cos(2 * x);
            Console.WriteLine($"Для значения x = {x}, F = {F}.");

        }
    }
}
