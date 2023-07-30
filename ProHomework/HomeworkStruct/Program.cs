namespace HomeworkStruct
{
    public class Program
    {
        //Завдання 3 (Структури)
        //Створіть структуру «Десяткове число». 
        //Визначте в ній необхідні поля і методи.Реалізуйте наступну функціональність: 
        //■ Перевести число у двійкову систему; 
        //■ Перевести число у вісімкову систему; 
        //■ Перевести число у шістнадцяткову систему.

        struct DecimalNumber
        {
            int value;

            public DecimalNumber(int value)
            {
                this.value = value;
            }

            public override string ToString()
            {
                return value.ToString();
            }

            // Перевести число у двійкову систему
            public string ToBinary()
            {
                return Convert.ToString(value, 2);
            }

            // Перевести число у вісімкову систему
            public string ToOctal()
            {
                return Convert.ToString(value, 8);
            }

            //Перевести число у шістнадцяткову систему
            public string ToHexadecimal()
            {
                return Convert.ToString(value, 16).ToUpper();
            }
        }

        public static void Main()
        {
            DecimalNumber number = new DecimalNumber(255);

            Console.WriteLine($"Десяткове: {number}");
            Console.WriteLine($"Двійкове: {number.ToBinary()}");
            Console.WriteLine($"Вісимкове: {number.ToOctal()}");
            Console.WriteLine($"Шістнадцяткове: {number.ToHexadecimal()}");


            Console.ReadKey();
        }
    }
}

