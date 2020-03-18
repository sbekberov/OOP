using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_OOP_CS
{
    class Program
    {

        static void Main()
        {
            Text mytext = new Text();

            mytext.inputtext();
            mytext.upper();
            Console.Write("\nIf take first letters to upper case: \n");
            mytext.printT();
            mytext.charDelete();
            Console.WriteLine("\nAfter this string deleting: ");
            mytext.printT();

            Console.WriteLine($"The length of the biggest string: {mytext.maxlensearch()}");

            int n;
            Console.Write("Choose what string to del: ");
            n = int.Parse(Console.ReadLine());
            n = n - 1;

            mytext.delline(n);
            mytext.printT();

            mytext = DelText(mytext);
            Console.WriteLine("\nText after deleting all strings: ");
            mytext.printT();

            Console.ReadKey();
        }

        static Text DelText(Text txt)
        {
            for (int i = 0; i <= txt.n; ++i)
            {
                txt.delline(i);
            }

            txt.n = txt.n - 1;
            return txt;
        }
    }
}
