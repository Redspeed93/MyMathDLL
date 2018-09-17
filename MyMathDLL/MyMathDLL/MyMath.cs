using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathDLL
{
    public static class MyMath
    {
        /// <summary>
        /// Takes two numbers and adds them 
        /// </summary>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Takes two numbers and subtracts them
        /// </summary>
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Takes two numbers and multiplies them
        /// </summary>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Takes two numbers and divides them
        /// </summary>
        public static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
