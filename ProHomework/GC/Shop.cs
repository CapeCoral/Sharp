using System;
namespace GCHommework
{
    //Завдання 2
    //Створіть клас «Магазин», який має зберігати таку інформацію: 
    //назва магазину;
    //адреса магазину;
    //тип магазину: o продовольчий, o господарський, o одяг, o взуття.
    //Реалізуйте у класі методи та властивості, необхідні для функціонування класу. 
    //Клас має реалізовувати інтерфейс IDisposable. 
    //Напишіть код для тестування функціональності класу. 
    //Напишіть код для виклику методу Dispose.

    public enum ShopType
	{
        Food,
        Hardware,
        Clothing,
        Shoes
    
    }
	public class Shop : IDisposable
	{
        private bool disposedValue;

        public string Name { get; private set; }
        public string Address { get; private set; }
        public ShopType Type { get; private set; }

		public Shop(string name,string address, ShopType type)
		{
            Name = name;
            Address = address;
            Type = type;
		}

        public void Show()
        {
            Console.WriteLine($"\nНазва магазину: {Name}" +
                $"\nАдреса : {Address}" +
                $"\nТип : {Type}");
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // Відключити та очистити управляючі ресурси
                }
                //Відключити та очистити неуправляючі ресурси

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Завдання 3

        ~Shop()
        {
            Dispose(false);
        }
    }
}

