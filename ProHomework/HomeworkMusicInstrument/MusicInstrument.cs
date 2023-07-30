using System;
namespace HomeworkMusicInstrument
{
	public abstract class MusicInstrument
	{
		private string name;
		private string description;
		private string history;

        public MusicInstrument(string name, string description, string history)
		{
			this.name = name;
			this.description = description;
			this.history = history;
		}

		public string GetName()
		{
			return name;
		}

		public virtual void Sound()
		{
			Console.WriteLine("Какой-то звук");
		}

		public void Show()
		{
			Console.WriteLine(name);
		}

        public void Description()
        {
			Console.WriteLine(description);
        }

        public void History()
        {
			Console.WriteLine(history);
        }
    }
}

