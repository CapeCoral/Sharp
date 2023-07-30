using System;
namespace HomeworkMusicInstrument
{
	public class Cello : MusicInstrument
    {
        public Cello(string name, string description, string history) : base(name, description, history)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("Уиу-уиу!");
        }
    }
}

