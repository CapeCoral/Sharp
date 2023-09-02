using System;
using System.Threading;

namespace ThreadingHommework
{
    class Program
    {
        static Semaphore barber = new Semaphore(0, 1);
        static Semaphore queue = new Semaphore(3, 3);

        static bool work;

        static string[] names = new string[] { "Толя", "Валя", "Петя", "Дима", "Стасик" };
        static string[] haircuts = new string[] { "Бокс", "Полубокс", "Как у Влада Ямы", "Оселедець", "Каре", "Модная", "Не модная" };

        class Barber
        {
            Thread thread;
            Random random;

            public Barber()
            {
                random = new Random();

                thread = new Thread(Work);
                thread.Start();
            }

            void Work()
            {
                while (true)
                {
                    Console.WriteLine("Барбер спит...");
                    barber.WaitOne();
                    work = true;
                    Console.WriteLine("Барбер стрижет...");
                    Thread.Sleep(random.Next(1000, 2000));
                    Console.WriteLine("Барбер закончил стрижку");
                    work = false; // отпускает клиента
                    barber.Release();
                }
            }
        }

        class Customer
        {
            string name;
            Thread thread;
            Random random;

            public Customer(string name)
            {
                this.name = name;

                random = new Random();

                thread = new Thread(Wait);
                thread.Start();
            }

            void Wait()
            {
                // Имитация интервала между посетителями
                Thread.Sleep(random.Next(500, 20000));
                Console.WriteLine($"Заходит {name}");

                if (!work) // барбер бездельничает
                {
                    Console.WriteLine($"{name} будит барбера");
                    barber.Release();
                    barber.WaitOne(); // ждет пока барбер работает

                    Console.WriteLine($"{name} уходит с прической '{haircuts[random.Next(0, haircuts.Length)]}'");
                }
                else
                {
                    // Ждет немного времени
                    if (queue.WaitOne(random.Next(3000, 5000)))
                    {
                        Console.WriteLine($"{name} садится ждать в очереди");

                        barber.WaitOne(); // ждет пока барбер работает

                        Console.WriteLine($"{name} будит барбера");
                        barber.Release();
                        queue.Release();

                        barber.WaitOne(); // ждет пока барбер работает

                        Console.WriteLine($"{name} уходит с прической '{haircuts[random.Next(0, haircuts.Length)]}'");
                    }
                    else // Надоело ждать стоя
                    {
                        Console.WriteLine($"{name} уходит не дождавшись");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            var barber = new Barber();
            var random = new Random();

            for (int i = 0; i < names.Length; i++)
            {
                var customer = new Customer(names[i]);
            }

            Console.ReadKey();
        }
    }
}

