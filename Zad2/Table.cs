using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad2
{
    class Table : ITable
    {




        private int[] temps = new int[100];

        public Table(int size)
        {
            this.temps = new int[size];

        }
        public Table()
        {
            this.temps = new int[1];

        }

        public int this[int index]
        {
            get
            {
                // This is invoked when accessing Layout instances with the [ ].
                if (index >= 0 && index < this.temps.Length)
                {
                    // Bounds were in range, so return the stored value.
                    return temps[index];
                }
                else
                {
                    return -1;
                }
            
            }
            set
            {
                if (index >= 0 && index < temps.Length)
                {
                    // Assign to this element slot in the internal array.
                    temps[index] = value;
                }
            }
        }






        public int getElement(int index)
        {
            return temps[index];
        }

        public void addElement(int element)
        {
            int lenght = temps.Length;
            int[] newTable = new int[lenght + 1];
            Array.Copy(this.temps, newTable, lenght);
            newTable[lenght] = element;
            this.temps = newTable;

        }
    }
}
