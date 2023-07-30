using System;
namespace HomeworkMusicInstrument
{
	public class Violin : MusicInstrument
    {
        public Violin(string name, string description, string history) : base(name, description, history)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("Пам-пам!");
        }
    }
}

