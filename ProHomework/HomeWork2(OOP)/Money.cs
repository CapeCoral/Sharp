using System;
namespace HomeWork2_OOP
{
    public class Money
	{
		public enum Currency
		{
			None,
			USD,
			EUR,
			UAH
		}


		public Currency CurrencyCode { get; private set; }

		private int amount;
		public int Amount
		{
			get { return amount; }
			private set
			{
				// Ограничить отрицательную сумму
				if (value < 0)
					value = 0;

				amount = value;
			}
		}
        private int trifle;
        public int Trifle
        {
            get { return trifle; }
            private set
            {
                // Ограничить отрицательную сумму
                if (value < 0)
                    value = 0;

                trifle = value;
            }
        }

        public Money(Currency currency, int amount, short trifle = 0)
		{
			CurrencyCode = currency;
			Amount = amount;
			Trifle = trifle;

			// Проверка целого значения и копеек
            if (Trifle >= 100)
            {
                Amount += Trifle / 100;
                Trifle %= 100;
            }
        }

		/// <summary>
		/// Получить сумму и валюту
		/// </summary>
		public override string ToString()
		{
			return $"{Amount},{Trifle} {CurrencyCode}";
		}

		/// <summary>
		/// Добавить сумму
		/// </summary>
		public void Add(Money money)
		{
			Amount += money.Amount;
			Trifle += money.Trifle;
		}

		/// <summary>
		/// Отнять сумму
		/// </summary>
		public void Subrtract(Money money)
		{
            Amount -= money.Amount;
            Trifle -= money.Trifle;
        }
	}
}