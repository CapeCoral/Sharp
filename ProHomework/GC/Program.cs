
namespace GCHommework
{
    public class Program
    {
        public static void Main()
        {
            // Завдання 1/3
            using (APlay play = new APlay("Ромео і Джульєтта", "Вільям Шекспір", "Трагедія", 1597))
            {
                play.ShowInfo();
            }

            Console.WriteLine("П'єса була видалена");

            // Завдання 2/3
            using (Shop foodShop = new Shop("Torts.UA", "Cавченко 3", ShopType.Food))
            {
                foodShop.Show();
            }

            Console.WriteLine("Магазин був видалений");

            using (Shop hardware = new Shop("Аврора", "Вокзальна 13", ShopType.Hardware))
            {
                hardware.Show();
            }

            Console.WriteLine("Магазин був видалений");


            Console.ReadKey();
        }
    }
}


