using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad2
{
    class Table{

    
   private int[] temps;


    public int Length
    {
        get { return temps.Length; }
    }

    public int this[int index]
    {
        get
        {
            return temps[index];
        }

        set
        {
            temps[index] = value;
        }
    }



}
