using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad2
{
    class InvalidIndexException : Exception
    {
        public InvalidIndexException(string message)
            : base("Invalid index" + message) { }
        public InvalidIndexException()
            : base("Invalid index") {
                System.Console.WriteLine("Bad index");
            }

        
    }
}
