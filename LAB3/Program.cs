using System;

namespace LAB3_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Array arr = new Array();
            arr.InputArray();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Amount of Vowels: " + arr.Getamount);
            Console.WriteLine();
            Console.WriteLine(" Result : ");
            Console.WriteLine(arr[0] + " " + arr[1] + " " + arr[2] + " " + arr[3] + " " + arr[4] + " " + arr[5] + " " + arr[6] + " " + arr[7] + " " + arr[8] + " " + arr[9]);
                   
        }
    }
}
