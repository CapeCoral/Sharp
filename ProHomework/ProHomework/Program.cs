using ProHomework;
using System;
using System.Text;

namespace Lesson
{
    public class Program
    {
        public static void Main()
        {
            Calculator calculator = new Calculator();

            int resultAdd = calculator.Add(5, 3); // Результат: 8
            int resultSubtract = calculator.Subtract(10, 4); // Результат: 6
            int resultMultiply = calculator.Multiply(2, 6); // Результат: 12

            try
            {
                int resultDivide = calculator.Divide(10, 5); // Результат: 2
                Console.WriteLine("Результат ділення: " + resultDivide);
            }
            catch (ArgumentException)
            {
                throw new Exception();
            }
            
            int resultPower = calculator.Power(2, 3); // Результат: 8, тобто 2^3

            Console.WriteLine("Результат додавання: " + resultAdd);
            Console.WriteLine("Результат віднімання: " + resultSubtract);
            Console.WriteLine("Результат множення: " + resultMultiply);
            
            Console.WriteLine("Результат піднесення до степеня: " + resultPower);

            Console.ReadKey();

        }
    }
}
