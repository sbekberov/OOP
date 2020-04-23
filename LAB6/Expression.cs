using System;

namespace LAB6_OOP_CS
{
    class Expression
    {
       

        public double A, C, D;
        
        public Expression(double a,  double c, double d)
        {
            A = a;
            C = c;
            D = d;
        }

        public double Сalculating()
        {
            
            if  ((2 * C - A) < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if ((A / 4 + C) == 0)
            {
                throw new DivideByZeroException();
            }

            
            return (Math.Log((2 * C - A), 10) + D - 152) / (A / 4 + C);

        }
        
        #region
        public static Expression operator +(Expression example, int num)
        {
            return new Expression(example.A + num, example.C + num, example.D + num);
        }
        public static Expression operator +(Expression example1, Expression example2)
        {
            return new Expression(example1.A + example2.A, example1.C + example2.C, example1.D + example2.D);
        }
        public static Expression operator -(Expression example, int num)
        {
            return new Expression(example.A - num, example.C - num, example.D - num);
        }
        public static Expression operator -(Expression example1, Expression example2)
        {
            return new Expression(example1.A - example2.A, example1.C - example2.C, example1.D - example2.D);
        }
        #endregion

    }
}