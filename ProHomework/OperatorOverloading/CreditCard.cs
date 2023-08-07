using System;
namespace OperatorOverloading
{
    //Створiть та опишiть клас «Кредитна картка». 
    //Додайте до вже створеного класу інформацію про суму грошей на картці.
    //Виконайте перевантаження
    //+ (для збільшення суми грошей на вказану кількість), 
    //– (для зменшення суми грошей на вказану кількість), 
    //== (перевірка на рівність CVC коду), 
    //< і > (перевірка на меншу чи більшу кількість суми грошей), 
    //!= і Equals.
    //Використовуйте механізм властивостей полів класу.


    public class CreditCard
	{
        private string cvc;
        private decimal balance;

        public CreditCard(string cvc, decimal initialBalance)
        {
            this.cvc = cvc;
            this.balance = initialBalance;
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public static CreditCard operator +(CreditCard card, decimal amount)
        {
            card.balance += amount;
            return card;
        }

        public static CreditCard operator -(CreditCard card, decimal amount)
        {
            if (card.balance >= amount)
                card.balance -= amount;
            else
                Console.WriteLine("Недостатній баланс.");

            return card;
        }

        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            return card1.cvc == card2.cvc;
        }

        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return card1.cvc != card2.cvc;
        }

        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return card1.balance < card2.balance;
        }

        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return card1.balance > card2.balance;
        }


        public override string ToString()
        {
            return balance.ToString();
        }
    }
}

