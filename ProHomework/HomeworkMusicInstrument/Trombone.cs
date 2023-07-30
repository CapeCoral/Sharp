using System;
namespace HomeworkMusicInstrument
{
	public class Trombone : MusicInstrument
    {
		public Trombone(string name, string description, string history) : base(name, description, history)
		{
			
		}

        public override void Sound()
        {
            Console.WriteLine("Пум-пум!");
        }
    }
}

