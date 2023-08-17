
namespace OperatorOverloading
{

    public class Program
    {
        public static void Main()
        {
            // Завдання 1
            var employee1 = new Employee(10000);
            var employee2 = new Employee(15000);

            employee1 += 100;
            employee2 -= 100;

            var isSalarySame = employee1 == employee2;
            var isBiggerSalary = employee1 > employee2;
            var isSameEmployee = employee1.Equals(employee2);

            

            // Завдання 2
            var matrix1 = new Matrix(3, 3, true);
            var matrix2 = new Matrix(3, 3, true);

            Console.WriteLine($"\nМатриця 1:\n {matrix1}\nМатриця 2:\n {matrix2}");

            if (matrix1 == matrix2)
            {
                Console.WriteLine("\nУ матриць однакові розміри, можна додавати і віднімати");

                matrix1 += matrix2;
                //matrix1 -= matrix2;

                Console.WriteLine("\nПісля складання:");
                Console.WriteLine($"\nМатриця 1:\n {matrix1}\nМатриця 2:\n {matrix2}");
            }
            
            matrix1 *= 5;

            Console.WriteLine("\nПісля множення на 5:");
            Console.WriteLine($"\nМатриця 1:\n {matrix1}\nМатриця 2:\n {matrix2}");

            if (matrix1.Rows == matrix2.Columns)
            {
                Console.WriteLine("\nСтовбці першої рівні строкам другої, можна множити одну на другу");

                matrix1 *= matrix2;

                Console.WriteLine($"\nМатриця 1:\n {matrix1}\nМатриця 2:\n {matrix2}");
            }

            bool isSameMatrix = matrix1.Equals(matrix2);
            Console.WriteLine(isSameMatrix ? "\nодин і той же екземпляр матриці" : "\n2 різних экземпляра матриць");

            // Завдання 3
            var people1 = new City(1000000);
            var people2 = new City(1200000);

            people1 += 1500;
            people2 -= 1000;

            var isPeopleSame = people1 == people2;
            var isBiggerPeople = people1 > people2;
            var isSameCity = people1.Equals(people2);

            // завдання 4
            CreditCard card1 = new CreditCard("123", 1000.00m);
            CreditCard card2 = new CreditCard("456", 1500.30m);

            Console.WriteLine("Початковий баланс:");
            Console.WriteLine("Card 1: " + card1.Balance);
            Console.WriteLine("Card 2: " + card2.Balance);

            card1 += 500.00m;
            card2 -= 200.00m;

            Console.WriteLine("\nОновлений баланс:");
            Console.WriteLine("Card 1: " + card1.Balance);
            Console.WriteLine("Card 2: " + card2.Balance);

            if (card1 == card2)
            {
                Console.WriteLine("\nКартки мають однаковий CVC.");
            }
            else
            {
                Console.WriteLine("\nКартки мають різний CVC.");
            }

            if (card1 > card2)
            {
                Console.WriteLine("Картка 1 має білший баланс ніж картка 2.");
            }
            else if (card1 < card2)
            {
                Console.WriteLine("Картка 1 має менший баланс ніж картка 2.");
            }
            else
            {
                Console.WriteLine("Картки мають однаковий баланс.");
            }

            var isSameBalance = card1.Equals(card2);

            Console.ReadKey();
        }
    }
}

