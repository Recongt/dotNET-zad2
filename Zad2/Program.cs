using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {

            Table a = new Table();
            a.addElement(1);
            a[1] = 3;
            a.addElement(2);
            System.Console.WriteLine(a[2]);

            System.Console.ReadLine();
        }
    }
}
