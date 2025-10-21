using System;

class Program
{
    static void Main()
    {
        try
        {
           
            Range r1 = new Range(1.0,5.0);



            r1.End = -6;


            Range r2 = new Range(-2.0, 3.0);
            Range r3 = new Range(0.0, 0.0);
           

            
            Console.WriteLine("Проверка класса Range");

            r1.PrintRange();
            Console.WriteLine($"Точка 3.0 внутри? {r1.IsInside(3.0)}"); 
            Console.WriteLine($"Точка 5.0 внутри? {r1.IsInside(5.0)}"); 
            Console.WriteLine();

            r2.PrintRange();
            Console.WriteLine($"Точка -1.0 внутри? {r2.IsInside(-1.0)}"); 
            Console.WriteLine();

            r3.PrintRange();
            Console.WriteLine($"Точка 0.0 внутри? {r3.IsInside(0.0)}"); 
            Console.WriteLine();

            // Создание неверного интервала (начало > конец)
            //Range bad = new Range(5.0, 1.0); 

            // Изменение границ через свойства
             //r1.Start = 6.0; 
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
