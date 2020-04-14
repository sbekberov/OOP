using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_OOP
{
    public class Base
    {
        public string first_line;

        public Base(string a)
        {
            first_line = a;
        }

        public int GetLength()
        {
            return first_line.Length;
        }
    }

}