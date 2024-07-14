using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo_Ass_2
{
    internal struct PhoneBook
    {
        // Attributes
        string[] names;
        long[] numbers;

        // length Of Array
        int size;

        // Property Size
        public int Size
        {
            get { return size; }
        }

        // Constructor
        public PhoneBook(int _size)
        {
            size = _size;
            //Create an Array of names
            names = new string[size];
            //Create an Array of number  	
            numbers = new long[size];

        }

        // Method AddPerson
        public void addPerson(int Position, string Name, long Number)
        {
            if (names is not null && numbers is not null) ;
            {

                if (Position >= 0&& Position <= size)
                {
                    names[Position] = Name;

                    numbers[Position] = Number;

                    return;
                }
            }
        }
        /*
            /* ======================= With Using Full Property ======================= */

        // Getter
        public long GetNumber(string Name)
        {
            if (names != null & numbers is not null)
            {
                for (int i = 0; i<names.Length; i++)
                {

                    if (Name == names[i])
                    {
                        return numbers[i];

                    }

                }
            }
            return -1;
        }

        // Setter 
        public long SetNumber(string Name, long NewNumber)
        {
            if (names != null & numbers is not null)
            {
                for (int i = 0; i<names.Length; i++)
                {

                    if (Name == names[i])
                    {
                        numbers[i] = NewNumber;
                    }

                }
            }
            return -1;
        }



        /* ======================= With Using Indexer ======================= */
        public long this[string name]
        {
            // Setter

            get
            {
                for (int i = 0; i < size; i++)
                {
                    if (names[i] == name)
                    {
                        return numbers[i];
                    }
                }
                return -1; // Indicating not found
            }


            // Getter 
            set
            {
                for (int i = 0; i < size; i++)
                {
                    if (names[i] == name)
                    {
                        numbers[i] = value;
                        return;
                    }
                }
            }
        }
    }

    

}



