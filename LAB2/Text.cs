using System;
using System.Collections.Generic;
using System.Text;

namespace LAB2_OOP_CS
{
    class Text
    {
        private Line[] str = new Line[15];

        public int n;

        public void delline(int ind)
        {
            for (int i = ind; i <= n; i++)
            {
                str[i] = str[i + 1];
            }
            --n;
        }

        public int maxlensearch()
        {

            int mx = str[0].maxwlen();
            for (int i = 0; i < n; i++)
            {
                if (mx < str[i].maxwlen())
                {
                    mx = str[i].maxwlen();
                }
            }
            return mx;
        }

        public void printT()
        {
            for (int i = 0; i < n; i++)
            {
                str[i].printString();
            }

        }

        public void charDelete()
        {
            char ct;
            Console.Write("Enter char, what string you want to del:");
            ct = Console.ReadKey().KeyChar;
            for (int j = 0; j < n; j++)
            {
                if (str[j].search(ct) == true)
                {
                    for (int i = j; i <= n; i++)
                    {
                        str[i] = str[i + 1];
                    }
                    --n;
                    j--;
                }

            }
        }

        public void newline()
        {
            Console.Write("New Line:");
            str[n].inputString();
            ++n;
        }

        public void inputtext()
        {
            Console.Write("Enter number of lines: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter text: ");
            for (int i = 0; i < n; i++)
            {
                str[i] = new Line();
                str[i].inputString();
            }
            Console.WriteLine();
        }

        public void upper()
        {
            for (int i = 0; i < n; i++)
            {
                str[i].lineupper();
            }
        }
    }
}
