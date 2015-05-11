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
            for (int i = 0; i < 8; i++)
            {
                a[i] = i;
            }

                //System.Console.WriteLine(a[3]);

                System.Console.WriteLine("Rozmiar: {0}", a.getlenght());
            
            for (int i = 0; i < a.getlenght(); i++)
            {
                System.Console.Write("{0}: {1} , ", i, a[i]);
            }


                System.Console.ReadLine();
        }
    }
}
