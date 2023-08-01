using System;
using System.Linq;
namespace Interface
{
    //Завдання 1 
    //Створіть інтерфейс IOutput.
    //У ньому мають бути два методи: 
    //■ void Show() — відображає інформацію; 
    //■ void Show(string info) — відображає інформацію та інформаційне повідомлення, зазначене у параметрі info.
    //Створіть клас Array (масив цілого типу) із необхідними методами.
    //Цей клас має імплементувати інтерфейс IOutput.
    //Метод Show() — відображає на екран елементи масиву.
    //Метод Show(string info) — відображає на екрані елементи масиву та інформаційне повідомлення, зазначене у параметрі info. 
    //Напишіть код для тестування отриманої функціональності.

    public interface IOutput
    {
        void Show();
        void Show(string info);
    }


   // Завдання 2 
   //Створіть інтерфейс IMath.
   //У ньому мають бути чотири методи: 
   //■ int Max() — повертає максимум; 
   //■ int Min() — повертає мінімум;
   //■ float Avg() — повертає середньоарифметичне; 
   //■ bool Search(int valueToSearch) — шукає valueSearch всередині контейнера даних.
   //- Повертає true, якщо значення знайдено.
   //- Повертає false, якщо значення не знайдено.
   //Клас, створений у першому завданні Array, має імплементувати інтерфейс IMath. 
   //Метод Max — повертає максимум серед елементів масиву.
   //Метод Min — повертає мінімум серед елементів масиву.
   //Метод Avg — повертає середньоарифметичне серед елементів масиву.
   //Метод Search — шукає значення всередині масиву. 
   //- Повертає true, якщо значення знайдено.
   //- Повертає false, якщо значення не знайдено. 
   //Напишіть код для тестування отриманої функціональності

    public interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }


    // Завдання 3
    //Створіть інтерфейс ISort.
    //У ньому мають бути три методи: 
    //■ void SortAsc() — сортування за зростанням; 
    //■ void SortDesc() — сортування за зменшенням; 
    //■ void SortByParam(bool isAsc) — сортування залежно від переданого параметра.
    //Якщо isAsc дорівнює true, сортуємо за зростанням.
    //Якщо isAsc дорівнює false, сортуємо за зменшенням
    //Клас, створений у першому завданні Array, має імплементувати інтерфейс ISort.
    //Метод SortAsc — сортує масив за зростанням. 
    //Метод SortDesc — сортує масив за спаданням. 
    //Спосіб SortByParam — сортує масив залежно від переданого параметра. 
    //Якщо isAsc дорівнює true, сортуємо за зростанням.
    //Якщо isAsc дорівнює false, сортуємо за зменшенням.
    //Напишіть код для тестування отриманої функціональності.

    public interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }

    public class MyArray : IOutput, IMath, ISort
	{
        private int[] data;

        // params дозволяє зручно передавати будь-яку кількість аргументів одного типу без необхідності явно створювати масив
        public MyArray(params int[] elements)
        {
            data = elements;
        }

       
        public void Show()
        {
            Console.WriteLine("Масив цілих чисел:");
            foreach (int num in data)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Show();
            Console.WriteLine($"Інформаційне повідомлення: {info}");
        }

        // Завдання 2 
        public float Avg()
        {
            int sum = 0;
            foreach (int num in data)
            {
                sum += num;
            }
            return (float)sum / data.Length;
        }

        public int Max()
        {
            int max = data[0];
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] > max)
                    max = data[i];
            }
            return max;
        }

        public int Min()
        {
            int min = data[0];
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] < min)
                    min = data[i];
            }
            return min;
        }

        public bool Search(int valueToSearch)
        {
            foreach (int num in data)
            {
                if (num == valueToSearch)
                    return true;
            }
            return false;
        }

        // Завдання 3
        public void SortAsc()
        {
            Array.Sort(data);
        }

        public void SortDesc()
        {
            Array.Sort(data);
            Array.Reverse(data);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }

        public void PrintArray()
        {
            Console.WriteLine("Масив цілих чисел:");
            foreach (int num in data)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }

    }
}

