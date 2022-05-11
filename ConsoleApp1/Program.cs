using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateValue = new DateTime(2008, 6, 11);
            Console.WriteLine(dateValue.ToString("dd число" + " ( dddd )"));



            Console.ReadKey();

        }

    }
}
