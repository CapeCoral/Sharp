using System;
namespace OperatorOverloading
{
    //Створiть та опишiть клас «Місто». 
    //Виконайте перевантаження
    //+ (для збільшення кількості жителів на вказану кількість), 
    //– (для зменшення кількості жителів на вказану кількість), 
    //== (перевірка на рівність двох міст за кількістю жителів), 
    //< і > (перевірка на меншу чи більшу кількість мешканців), 
    //!= і Equals.
    //Використовуйте механізм властивостей полів класу.


    public class City
	{
        private int people;

		public City(int people)
		{
            this.people = people;
		}

        public static City operator +(City people1, int add)
        {
            return new City(people1 .people + add);
        }

        public static City operator -(City people1, int sub)
        {
            return new City(people1.people - sub);
        }

        public static bool operator ==(City a, City b)
        {
            return a.people == b.people;
        }

        public static bool operator !=(City a, City b)
        {
            return a.people != b.people;
        }

        public static bool operator >(City a, City b)
        {
            return a.people > b.people;
        }

        public static bool operator <(City a, City b)
        {
            return a.people < b.people;
        }

        public override string ToString()
        {
            return people.ToString();
        }
    }
}

