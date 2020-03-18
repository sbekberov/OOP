using System;
using System.Collections.Generic;
using System.Text;

namespace LAB2_OOP_CS
{
    class Line
    {
        private char[] word;
        private int size;

        public char[] str;

        public Line()
        {
            size = 100;
            str = new char[size];

        }

        public int maxwlen()
        {
            return str.Length;
        }

        public void inputString()
        {
            str = Console.ReadLine().ToCharArray();
        }

        public void printString()
        {
            Console.WriteLine(str);
        }

        public void lineupper()
        {
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] == ' ') || (i == 0))
                    str[i] = char.ToUpper(str[i]);
            }
        }

        public bool search(char ch)
        {
            string s = new string(str);
            bool f = false;
            if (s.Contains(ch.ToString()))
                f = true;
            return f;
        }
    }
}
