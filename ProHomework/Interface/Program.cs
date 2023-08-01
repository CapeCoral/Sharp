using System.Collections.Generic;

namespace Interface
{
   
    public class Program
    {
        public static void Main()
        {
            MyArray array = new MyArray(10, 30, 5, 20, 15);

            //Завдання 1 
            array.Show(); // Виведе масив цілих чисел
            array.Show("Тестове повідомлення"); // Виведе масив цілих чисел та інформаційне повідомлення

            // Завдання 2 
            Console.WriteLine("Максимум: " + array.Max()); // Виведе 30
            Console.WriteLine("Мінімум: " + array.Min()); // Виведе 5
            Console.WriteLine("Середнє арифметичне: " + array.Avg()); // Виведе 16
            //int valueToSearch = 20; // Знайдено
            int valueToSearch = 25; // Не знайдено

            if (array.Search(valueToSearch))
                Console.WriteLine($"Значення {valueToSearch} знайдено в масиві.");
            else
                Console.WriteLine($"Значення {valueToSearch} не знайдено в масиві.");


            // Завдання 3
            Console.WriteLine("Масив до сортування:");
            array.PrintArray();

            // Сортування за зростанням
            array.SortAsc();
            Console.WriteLine("Масив після сортування за зростанням:");
            array.PrintArray();

            // Сортування за спаданням
            array.SortDesc();
            Console.WriteLine("Масив після сортування за спаданням:");
            array.PrintArray();

            // Сортування в залежності від параметра
            bool isAscending = false; // Можна замінити на true, якщо відсортувати за зростанням
            array.SortByParam(isAscending);
            Console.WriteLine("Масив після сортування за заданим параметром:");
            array.PrintArray();

            Console.ReadKey();
        }
    }
}

