using System;
using System.IO;
namespace ConsoleApp10
{
    class Program
    {
        public static int price=0;
        public static int weight=0;
        public static ConsoleApp10.Menu menu = new Menu();
        
        static void Main(string[] args)
        {
            menu = new Menu();
            Console.WriteLine("Добро пожаловать в ресторан!");
            Console.WriteLine("Пожалуйста, выберите блюда из списка, введите 0 когда закончите выбор.");
            int ch;
            int sz;
            while (true)
            {
                menu.ShowAll();
                ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 0) break;
                else if (ch > 0 && ch <= menu.Size)
                {
                    Console.WriteLine("Введите 1 для заказа большого блюда, и 2 для заказа маленького");
                    sz = Convert.ToInt32(Console.ReadLine());
                    addDish(ch-1, sz - 1);
                    Console.Clear();
                    Console.WriteLine("Ваш заказ добавлен в чек! ");
                }
                else Console.WriteLine("Введите номер блюда");
            }
            string path = Environment.CurrentDirectory + @"\ticket.txt";
            File.AppendAllText(path, "Общая сумма : "+ price+ ", общий вес : "+ weight);
        }
        static void addDish(int d,int s)
        {
            string path = Environment.CurrentDirectory + @"\ticket.txt";
            File.AppendAllText(path, menu[d].getInfo(s)+ Environment.NewLine);
            price += menu[d].getPrice(s);
            weight += menu[d].getWeight(s);
        }
    }
}
