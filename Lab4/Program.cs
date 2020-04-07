using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Square K1 = new Square();
            Square K2 = new Square(1, 2, 4, 2, 1, 5, 4, 5);
            Square K3 = new Square(K1);

            Console.WriteLine($"Coords of K1 rhombus: \n" +
                $"Point A:({K1.GetX(Points.A)}, {K1.GetY(Points.A)}) " +
                $"Point B:({K1.GetX(Points.B)}, {K1.GetY(Points.B)}) " +
                $"Point C:({K1.GetX(Points.C)}, {K1.GetY(Points.C)}) " +
                $"Point D:({K1.GetX(Points.D)}, {K1.GetY(Points.D)})\n");
            
            Console.WriteLine($"Coords of K2 rhombus: \n" +
                $"Point A:({K2.GetX(Points.A)}, {K2.GetY(Points.A)}) " +
                $"Point B:({K2.GetX(Points.B)}, {K2.GetY(Points.B)}) " +
                $"Point C:({K2.GetX(Points.C)}, {K2.GetY(Points.C)}) " +
                $"Point D:({K2.GetX(Points.D)}, {K2.GetY(Points.D)})\n");
            
            Console.WriteLine($"Coords of K3 rhombus: \n" +
              $"Point A:({K3.GetX(Points.A)}, {K3.GetY(Points.A)}) " +
               $"Point B:({K3.GetX(Points.B)}, {K3.GetY(Points.B)}) " +
               $"Point C:({K3.GetX(Points.C)}, {K3.GetY(Points.C)}) " +
               $"Point D:({K3.GetX(Points.D)}, {K3.GetY(Points.D)})\n");

            Console.WriteLine($"Side length of K1 Square: {K1.Side.ToString("0.000")}");
            Console.WriteLine($"Side length of K2 Square: {K2.Side.ToString("0.000")}");
            Console.WriteLine($"Side length of K3 Square: {K3.Side.ToString("0.000")}");
            Console.WriteLine("");

            Console.WriteLine($"Square of K1 Square: {K1.square}");
            Console.WriteLine($"Square of K2 Square: {K2.square}");
            Console.WriteLine($"Square of K3 Square: {K3.square.ToString("0.")}");
            Console.WriteLine("");

            Console.WriteLine($"Perimetr of K1 Square: {K1.Perimetr.ToString("0.00")}");
            Console.WriteLine($"Perimetr of K2 Square: {K2.Perimetr.ToString("0.00")}");
            Console.WriteLine($"Perimetr of K3 Square: {K3.Perimetr.ToString("0.00")}");
            Console.WriteLine("");

          //  K1 = K2/K3;
            //Console.WriteLine($"Square K1 after subtraction K2/K3: {K1.square.ToString("0.")}");
            K3 = K3 + 5;
            Console.WriteLine($"Square K3 after subtraction K3+5: {K3.square.ToString("0.")}");

            Console.ReadKey();
        }
    }
}