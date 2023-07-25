using System;
namespace ProHomework
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Деление на ноль не допустимо");
            }

            return a / b;
        }

        public int Power(int a, int exponent)
        {
            if (exponent < 0)
            {
                throw new ArgumentException("Отрицательные показания степени не поддерживаются");
            }

            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= a;
            }

            return result;
        }
    }
}

