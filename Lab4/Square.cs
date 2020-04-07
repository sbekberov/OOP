using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_OOP
{
    public enum Points
    {
        A,
        B,
        C,
        D
    }

    class Square
    {

        private Point A;
        private Point B;
        private Point C;
        private Point D;

        private struct Point
        {
            public double x;
            public double y;
        };

        public Square()
        {
            A.x = 5;
            A.y = -2;

            B.x = 0;
            B.y = -4;

            C.x = 1;
            C.y = 8;

            D.x = -4;
            D.y = 6;
        }

        public Square(double a1, double a2, double b1, double b2, double c1, double c2, double d1, double d2)
        {
            A.x = a1;
            A.y = a2;

            B.x = b1;
            B.y = b2;

            C.x = c1;
            C.y = c2;

            D.x = d1;
            D.y = d2;
        }

        public Square(Square other)
        {
            A.x = other.A.x;
            A.y = other.A.y;

            B.x = other.B.x;
            B.y = other.B.y;

            C.x = other.C.x;
            C.y = other.C.y;

            D.x = other.D.x;
            D.y = other.D.y;
        }

        public double Side
        {
            get
            {
                return Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2));
            }
        }

        public double square
        {
            get
            {
                double square = Math.Pow(Side, 2);
                return square;

            }
        }

        public double Perimetr
        {
            get
            {

                double P = Side * 4;
                return P;

            }
        }

        public double GetX(Points point)
        {
            if (point == Points.A)
            {
                return A.x;
            }
            else if (point == Points.B)
            {
                return B.x;
            }
            else if (point == Points.C)
            {
                return C.x;
            }
            else if (point == Points.D)
            {
                return D.x;
            }

            return 0;
        }

        public double GetY(Points point)
        {
            if (point == Points.A)
            {
                return A.y;
            }
            else if (point == Points.B)
            {
                return B.y;
            }
            else if (point == Points.C)
            {
                return C.y;
            }
            else if (point == Points.D)
            {
                return D.y;
            }

            return 0;
        }



        private static Square Multiply(Square square, double number)
        {
            Square result = new Square(square);

            result.A.x = result.A.x * Math.Sqrt(number);
            result.A.y = result.A.y * Math.Sqrt(number);

            result.B.x = result.B.x * Math.Sqrt(number);
            result.B.y = result.B.y * Math.Sqrt(number);

            result.C.x = result.C.x * Math.Sqrt(number);
            result.C.y = result.C.y * Math.Sqrt(number);

            result.D.x = result.D.x * Math.Sqrt(number);
            result.D.y = result.D.y * Math.Sqrt(number);

            return result;
        }

        public static Square operator *(Square square, double number)
        {
            Square temp = Square.Multiply(square, number);
            return temp;
        }

   
        public static Square operator +(Square first, int a)
        {
            Square temp = new Square();
            double subtraction = first.square + a;
            temp = first * (subtraction / first.square);

            return temp;
        }

     /* 

        private static Square Multiply11(Square square1, Square square2)
        {
            Square result = new Square(square1);
            Square result2 = new Square(square2);

            result.A.x = result.A.x / result2.A.x;
            result.A.y = result.A.y / result2.A.y; ;

            result.B.x = result.B.x / result2.B.x;
            result.B.y = result.B.y * result2.B.y;

            result.C.x = result.C.x / result2.C.x;
            result.C.y = result.C.y / result2.C.y;

            result.D.x = result.D.x / result2.D.x;
            result.D.y = result.D.y / result2.D.y;

            return result;
        }

        public static Square operator /(Square square1, Square square2)
        {

            Square temp = Square.Multiply11(square1, square2);
            return temp;

        }
        */
       


    }  
}

