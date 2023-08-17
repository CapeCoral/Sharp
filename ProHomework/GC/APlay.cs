using System;
namespace GCHommework
{
    //Завдання 1
    //Створіть клас «П'єса», який має зберігати таку інформацію: 
    //назва п'єси; 
    //П.І.Б.автора; 
    //жанр; 
    //рік.
    //Реалізуйте у класі методи та властивості, необхідні для функціонування класу.
    //Додайте до класу деструктор.
    //Напишіть код для тестування функціональності класу.
    //Напишіть код для деструктора. 

    public class APlay : IDisposable
	{
		public string NameAPlay { get; private set; }
        public string Autor { get; private set; }
        public string Genre { get; private set; }
        public int Year { get; private set; }

		public APlay(string nameAPlay, string autor, string genre, int year)
		{
            NameAPlay = nameAPlay;
            Autor = autor;
            Genre = genre;
            Year = year;
		}

        public void ShowInfo()
        {
            Console.WriteLine($"Назва п'єси: {NameAPlay}," +
                $"\nП.І.Б. автора: {Autor}," +
                $"\nЖанр: {Genre}," +
                $"\nРік: {Year}");
        }


        ~APlay()
        {
            Dispose(false);
        }


        // Завдання 3

        private bool disposed = false;

       
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Відключити та очистити управляючі ресурси
                }

                // Відключити та очистити неуправляючі ресурси

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}

