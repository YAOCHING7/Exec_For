using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                string valur1 = new string(' ', i - 1);
                string valur2 = new string('*', 6 - i);
                Console.WriteLine(valur1 + valur2);

            }
        }
    }
}
