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
                    throw new InvalidIndexException() { 
                        
                    };
                }
            
            }
            set
            {
                if (index >= 0 && index < temps.Length)
                {
                    // Assign to this element slot in the internal array.
                    temps[index] = value;
                }
                else if (index >= 0 && index >= temps.Length)
                {
                    addFarElement(index, value);
                }
            }
        }


        public int getlenght()
        {
            return this.temps.Length-1;
        }



        public int getElement(int index)
        {
            return temps[index];
        }

        public void addElement(int element)
        {
            int lenght = temps.Length;
            int[] newTable = new int[lenght+1];
            Array.Copy(this.temps, newTable, lenght-1);
            newTable[lenght-1] = element;
            this.temps = newTable;

        }

        // funkcja gdy w indeksatorze damy daleko poza index nowy element

        private void addFarElement(int index, int element)
        {
            int lenght = temps.Length;
            int[] newTable = new int[index+1];
            Array.Copy(this.temps, newTable, lenght);
            newTable[index] = element;
            this.temps = newTable;
        }
    }
}
