using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;

            for (int i = 1; i <= rows; i++)
            {
                string space = new string(' ', rows - i);
                string stars = new string('*', 2 * i - 1);

                string row = space + stars;

                Console.WriteLine(row);
            }
        }
    }
}
