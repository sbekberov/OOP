using System;

namespace Lab5_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Base BaseClass = new Base("Bekberov");
            derived DerivativeClass = new derived("Bekberov", 12345, "Selim");

            Console.WriteLine("Первоначальные данные: ");
            Console.WriteLine(" ");
            DerivativeClass.output();


            Console.WriteLine("Длина : " + DerivativeClass.GetLength());

            DerivativeClass.ReverseLine();
            DerivativeClass.ReverseNumber();
            Console.WriteLine(" ");


            Console.WriteLine("Данные после операций: ");
            Console.WriteLine(" ");
            DerivativeClass.output();


            Console.WriteLine("Длина: " + DerivativeClass.GetLength());
        }
    }
}