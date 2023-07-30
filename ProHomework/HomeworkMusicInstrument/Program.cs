namespace HomeworkMusicInstrument
{
    public class Program
    {
       // Завдання 2 (ООП)
       //Створити базовий клас «Музичний інструмент» і похідні класи: «Скрипка», «Тромбон», «Укулеле», «Віолончель». 
       //За допомогою конструктора, встановити назву до кожного музичного інструменту і його характеристики.
       //Реалізуйте для кожного з класів методи:
       //■ Sound — видає звук музичного інструменту(пишемо текстом у консоль); 
       //■ Show — відображає назву музичного інструменту; 
       //■ Desc — відображає опис музичного інструменту; 
       //■ History — відображає історію створення музичного інструменту.
       //Додати iнкапсуляцiю до полiв та методiв якщо треба.

        public static void Main()
        {
            var instruments = new List<MusicInstrument>();

            instruments.Add(new Cello("Скрипка", "Струнный инструмент", "Скрипка придумана когда-то в 16 веке"));
            instruments.Add(new Trombone("Тромбон", "Духовой инструмент", "Тромбон придуман в 15 веке"));
            instruments.Add(new Ukulele("Укулеле", "Струнный инструмент", "Укулеле придуман в конце 19 века"));
            instruments.Add(new Violin("Виолончель", "Струнный инструмент", "Виолончель придумана в 16 веке"));

            while (true)
            {
                Console.WriteLine("Введите название инструмента:");
                var input = Console.ReadLine();

                MusicInstrument instrument = null;

                foreach (var i in instruments)
                {
                    if (i.GetName().Equals(input))
                    {
                        instrument = i;
                        break;
                    }
                }

                if (instrument == null)
                {
                    Console.WriteLine("Инструмент не найден!");
                }
                else
                {
                    instrument.Show();
                    instrument.Description();
                    instrument.History();
                    instrument.Sound();
                }
            }
        }
    }
}


