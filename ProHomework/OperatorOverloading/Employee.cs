using System;
namespace OperatorOverloading
{
   // Створiть та опишiть клас «Співробітник». 
   //Додайте до вже створеного класу інформацію про заробітну плату працівника.
   //Виконайте навантаження
   //+ (для збільшення зарплати на вказану кількість), 
   //– (для зменшення зарплати на вказану кількість), 
   //== (перевірка на рівність зарплат працівників), 
   //< і > (перевірка на меншу чи більшу кількість зарплат працівників), 
   //!= і Equals.Використовуйте механізм властивостей полів класу.


    public class Employee
	{
        private int salary;


		public Employee(int salary)
		{
			this.salary = salary;
		}


		public static Employee operator +(Employee salary1, int add)
		{
			return new Employee(salary1.salary + add);
		}

        public static Employee operator -(Employee salary1, int subtract)
        {
			var salary = salary1.salary - subtract;  
            return new Employee(salary >= 0 ? salary : 0);
        }

        public static bool operator ==(Employee a, Employee b)
        {
            return a.salary == b.salary;
        }

        public static bool operator !=(Employee a, Employee b)
        {
            return a.salary != b.salary;
        }

        public static bool operator >(Employee a, Employee b)
        {
            return a.salary > b.salary;
        }

        public static bool operator <(Employee a, Employee b)
        {
            return a.salary < b.salary;
        }

        public override string ToString()
        {
            return salary.ToString();
        }
    }
}

