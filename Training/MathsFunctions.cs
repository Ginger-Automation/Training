﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class MathsFunctions
    {
        public static int AddTwoNumbers(int first, int second)
        {
            return (first + second);
        }

        public static int SubrTractTwoNumbers(int first, int second)
        {
            int result = first - second;
            return result;
        }

        internal static void Multiply_TwoNumbers()
        {
            throw new NotImplementedException();
        }

        public static int Divide_TwoNumbers(int first,int second)
        {


            return first / second;

        }

        internal static void AddThreeNumbers()
        {
            int x = Divide_TwoNumbers(15,3);
            // throw new NotImplementedException();
        }

        internal static void SubtractThreeNumbers()
        {
            throw new NotImplementedException();
        }

        public static int MultiplyThreeNumbers(int first, int second, int third)
        {
            return first * second * third;
        }

        internal static int DivideThreeNumbers(int first = 1, int second = 1, int third = 1 )
        {
            return first / second / third;
        }

        public static int AverageTwoNumbers(int first, int second)
        {
            return (first+second)/2;
        }

        internal static void AverageThreeNumbers()
        {
            throw new NotImplementedException();
        }

        internal static void GetSquare()
        {
            throw new NotImplementedException();
        }

        internal static void GetCUbe()
        {
            throw new NotImplementedException();            
        }

        internal static void GetSquareRoot()
        {
            throw new NotImplementedException();
        }

        public static double GetCubeRoot(double input)
        {
            double Cube;
            Cube = Math.Ceiling(Math.Pow(input, (double)1 / 3));
            return Cube;
        }
    }
}
