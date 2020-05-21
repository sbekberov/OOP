using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_
{
    class Math
    {
        public delegate void MathHandler(string message);
        public event MathHandler Notify;
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Substraction(double a, double b)
        {
            return a - b;
        }
        public double Multiplication(double a, double b)
        {
            return a * b;
        }
        public double Division(double a, double b)
        {
            Notify?.Invoke($"Произошло деление");
            return a / b;
        }
    }
}
