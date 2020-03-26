using System;


namespace LAB3_OOP
{
    class Array
    {
        public char[] elements;
        public Array()
        {
            elements = new char[10] { 'n', 'K', 'i', 'x', 'A', 'w', 'Z', 'q', 'j', 'o' };
        }

        private int amount
        {
            get
            {
                int count = 0;
                for (int i = 0; i < elements.Length; i++)
                {
                    if ("eEyYuUiIoOaA".Contains(elements[i]))
                        count++;
                }
                return count;
            }
        }

        

        public int InputArray()
        {

            Console.Write(" Elements of array: ");
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write(elements[i] + ", ");
            }
            return 0;
        }

        public int Getamount
        {
            get
            {
                return amount;
            }
        }

        public char this[int index]
        {
            get
            {
                
                if (Char.IsUpper(elements[index]))
                    return elements[index];
                else
                    return '*';
            }
            set
            {
                elements[index] = value;
            }
        }
    }
}