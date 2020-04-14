using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_OOP
{
    class derived : Base
    {
        int number;
        string second_line;

        public derived(string a, int b, string c): base(a)
        {
            number = b;
            second_line = c;
        }

        public void output()
        {
            Console.WriteLine("Строка 1: " + first_line);
            Console.WriteLine("Цифровая строка: " + number);
            Console.WriteLine("Строка 2: " + second_line);
        }

        public void ReverseNumber()
        {
            int new_line = 0;
            int remainder;
            int n = number;
            while (n != 0)
            {
                remainder = n % 10;
                new_line = new_line * 10 + remainder;
                n /= 10;
            }
            
            number = new_line;
        }

        public void ReverseLine()
        {
            string new_line = "";
            for (int i = second_line.Length - 1; i >= 0; i--)
            {
                new_line += second_line[i];
            }
            second_line = new_line;
        }
    }
}