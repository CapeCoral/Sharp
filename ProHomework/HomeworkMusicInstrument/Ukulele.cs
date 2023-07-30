using System;
namespace HomeworkMusicInstrument
{
	public class Ukulele : MusicInstrument
    {
        public Ukulele(string name, string description, string history) : base(name, description, history)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("Дрынь-дрынь!");
        }
    }
}

