using CS_Static;

namespace CS_Static
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Date date1 = new Date(2023, 10, 15);
                Date date2 = new Date(2023, 12, 25);

                Console.WriteLine($"Date 1: {date1}");
                Console.WriteLine($"Date 2: {date2}");

                Date datePlus = date1 + 10;
                Console.WriteLine($"Date 1 + 10 дней: {datePlus}");

                Date dateMinus = date2 - 5;
                Console.WriteLine($"Date 2 - 5 дней: {dateMinus}");

                int daysDiff = date2 - date1;
                Console.WriteLine($"Разница между Date 2 и Date 1 : {daysDiff}");

                Date date3 = new Date(2023, 10, 15);
                Console.WriteLine($"Date 1 / Date 3: {date1.Equals(date3)}"); 
                
                Console.WriteLine("Тестирование валидации");
                Date invalidDate = new Date(2023, 2, 30);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка валидации: {ex.Message}");
            }

            Console.WriteLine("Программа завершена.");
        }
    }
}