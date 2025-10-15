using System;

namespace CS_Basics
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("=== Меню блоков ===");
                Console.WriteLine("Выберите блок задач:");
                Console.WriteLine("1. Блок 1: Переменные и операторы");
                Console.WriteLine("2. Блок 2: Условные операторы");
                Console.WriteLine("3. Блок 3: Циклы");
                Console.WriteLine("4. Блок 4: Массивы");
                Console.WriteLine("5. Блок 5: Функции");
                Console.WriteLine("0. Выход");
                Console.Write("\nВаш выбор: ");

                string? input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        ShowBlock1Menu();
                        break;
                    case "2":
                        ShowBlock2Menu();
                        break;
                    case "3":
                        ShowBlock3Menu();
                        break;
                    case "4":
                        ShowBlock4Menu();
                        break;
                    case "5":
                        ShowBlock5Menu();
                        break;

                    case "0":
                        isRunning = false;
                        Console.WriteLine("До свидания!");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        WaitForKey();
                        break;
                }
            }
        }

        // Блок 1
        static void ShowBlock1Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== БЛОК 1: Переменные и операторы ===");
                Console.WriteLine("1. Конвертация температуры (°C → °F)");
                Console.WriteLine("2. Конвертация валюты (RUB → USD)");
                Console.WriteLine("3. Среднее арифметическое трёх чисел");
                Console.WriteLine("0. Назад");
                Console.Write("\nВыберите задачу: ");

                string? choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1": Task1_1(); break;
                    case "2": Task1_2(); break;
                    case "3": Task1_3(); break;
                    case "0": return;
                    default: Console.WriteLine("Неверный выбор."); WaitForKey(); break;
                }
            }
        }

        // Блок 2
        static void ShowBlock2Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== БЛОК 2: Условные операторы ===");
                Console.WriteLine("1. Определение времени года по месяцу");
                Console.WriteLine("2. Определение координатной четверти");
                Console.WriteLine("3. Определение времени суток по часу");
                Console.WriteLine("0. Назад");
                Console.Write("\nВыберите задачу: ");

                string? choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1": Task2_1(); break;
                    case "2": Task2_2(); break;
                    case "3": Task2_3(); break;
                    case "0": return;
                    default: Console.WriteLine("Неверный выбор."); WaitForKey(); break;
                }
            }
        }

        // Блок 3
        static void ShowBlock3Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== БЛОК 3: Циклы ===");
                Console.WriteLine("1. Минимальная и максимальная цифра в числе");
                Console.WriteLine("2. Вывод первых n чисел Фибоначчи");
                Console.WriteLine("3. Среднее арифметическое n чисел");
                Console.WriteLine("0. Назад");
                Console.Write("\nВыберите задачу: ");

                string? choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1": Task3_1(); break;
                    case "2": Task3_2(); break;
                    case "3": Task3_3(); break;
                    case "0": return;
                    default: Console.WriteLine("Неверный выбор."); WaitForKey(); break;
                }
            }
        }
        // Блок 4
        static void ShowBlock4Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== БЛОК 4: Массивы ===");
                Console.WriteLine("1. Суммы строк и столбцов матрицы");
                Console.WriteLine("2. Переворот одномерного массива");
                Console.WriteLine("3. Разделение массива на положительные и отрицательные");
                Console.WriteLine("0. Назад");
                Console.Write("\nВыберите задачу: ");

                string? choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1": Task4_1(); break;
                    case "2": Task4_2(); break;
                    case "3": Task4_3(); break;
                    case "0": return;
                    default: Console.WriteLine("Неверный выбор."); WaitForKey(); break;
                }
            }
        }

        // Блок 5
        static void ShowBlock5Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== БЛОК 5: Функции ===");
                Console.WriteLine("1. Факториал числа");
                Console.WriteLine("2. Рекурсивная сумма массива");
                Console.WriteLine("3. Деление с остатком");
                Console.WriteLine("4. Фильтрация чётных чисел");
                Console.WriteLine("0. Назад");
                Console.Write("\nВыберите задачу: ");

                string? choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1": Task5_1(); break;
                    case "2": Task5_2(); break;
                    case "3": Task5_3(); break;
                    case "4": Task5_4(); break;
                    case "0": return;
                    default: Console.WriteLine("Неверный выбор."); WaitForKey(); break;
                }
            }
        }



        // Зачем нужна эта функция, chto ona delaet i gde vyzyvaetsia
        static void WaitForKey() // это "пауза", чтобы вы успели прочитать ответ программы, прежде чем она продолжит или вернётся в меню.
        {
            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }

        // Блок 1. Задачи
        static void Task1_1()
        {
            Console.Write("Введите температуру в °C: ");
            if (double.TryParse(Console.ReadLine(), out double c))
            {
                double f = c * 9 / 5 + 32;
                Console.WriteLine($"{c}°C = {f:F2}°F");
            }
            else Console.WriteLine("Ошибка ввода.");
            WaitForKey();
        }

        static void Task1_2()
        {
            const double RATE = 3.27;
            Console.Write("Введите сумму в рублях: ");
            if (double.TryParse(Console.ReadLine(), out double byn))
            {
                Console.WriteLine($"{byn} BYN = {byn / RATE:F2} USD (курс: {RATE})");
            }
            else Console.WriteLine("Ошибка ввода.");
            WaitForKey();
        }

        static void Task1_3()
        {
            Console.Write("Число 1: ");
            double a = double.TryParse(Console.ReadLine(), out double x1) ? x1 : 0;
            Console.Write("Число 2: ");
            double b = double.TryParse(Console.ReadLine(), out double x2) ? x2 : 0;
            Console.Write("Число 3: ");
            double c = double.TryParse(Console.ReadLine(), out double x3) ? x3 : 0;
            Console.WriteLine($"Среднее: {(a + b + c) / 3:F2}");
            WaitForKey();
        }

        // Блок 2. Задачи
        static void Task2_1()
        {
            Console.Write("Номер месяца (1-12): ");
            if (int.TryParse(Console.ReadLine(), out int m) && m >= 1 && m <= 12)
            {
                string? s = m switch { 12 or 1 or 2 => "Зима", 3 or 4 or 5 => "Весна", 6 or 7 or 8 => "Лето", _ => "Осень" };
                Console.WriteLine($"Время года: {s}");
            }
            else Console.WriteLine("Неверный номер месяца.");
            WaitForKey();
        }

        static void Task2_2()
        {
            Console.Write("X: ");
            double x = double.TryParse(Console.ReadLine(), out double xv) ? xv : 0;
            Console.Write("Y: ");
            double y = double.TryParse(Console.ReadLine(), out double yv) ? yv : 0;

            if (x == 0 || y == 0)
                Console.WriteLine("Точка на оси.");
            else
            {
                int q = (x > 0, y > 0) switch { (true, true) => 1, (false, true) => 2, (false, false) => 3, (true, false) => 4 };
                Console.WriteLine($"Четверть: {q}");
            }
            WaitForKey();
        }

        static void Task2_3()
        {
            Console.Write("Час (0-23): ");
            if (int.TryParse(Console.ReadLine(), out int h) && h >= 0 && h <= 23)
            {
                string t = h switch { >= 6 and < 12 => "Утро", >= 12 and < 18 => "День", >= 18 => "Вечер", _ => "Ночь" };
                Console.WriteLine($"Время суток: {t}");
            }
            else Console.WriteLine("Неверный час.");
            WaitForKey();
        }

        // Блок 3. Задачи
        static void Task3_1()
        {
            Console.Write("Введите целое число: ");
            if (long.TryParse(Console.ReadLine(), out long n))
            {
                n = Math.Abs(n);
                int min = 9, max = 0;
                if (n == 0) { min = max = 0; }
                while (n > 0)
                {
                    int d = (int)(n % 10);
                    if (d < min) min = d;
                    if (d > max) max = d;
                    n /= 10;
                }
                Console.WriteLine($"Мин. цифра: {min}, Макс. цифра: {max}");
            }
            else Console.WriteLine("Ошибка ввода.");
            WaitForKey();
        }

        static void Task3_2()
        {
            Console.Write("n = ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                Console.Write("Фибоначчи: ");
                long a = 0, b = 1;
                for (int i = 0; i < n; i++)
                {
                    if (i == 0) Console.Write(a);
                    else if (i == 1) Console.Write($", {b}");
                    else
                    {
                        long t = a + b;
                        a = b;
                        b = t;
                        Console.Write($", {b}");
                    }
                }
                Console.WriteLine();
            }
            else Console.WriteLine("n должно быть > 0.");
            WaitForKey();
        }

        static void Task3_3()
        {
            Console.Write("Количество чисел: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                double sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"Число {i}: ");
                    if (double.TryParse(Console.ReadLine(), out double x)) sum += x;
                }
                Console.WriteLine($"Среднее: {sum / n:F2}");
            }
            else Console.WriteLine("Ошибка ввода.");
            WaitForKey();
        }
        // Блок 4. Задачи
        static void Task4_1()
        {
            Console.Write("Строки: ");
            if (!int.TryParse(Console.ReadLine(), out int rows) || rows <= 0) { Console.WriteLine("Ошибка."); WaitForKey(); return; }
            Console.Write("Столбцы: ");
            if (!int.TryParse(Console.ReadLine(), out int cols) || cols <= 0) { Console.WriteLine("Ошибка."); WaitForKey(); return; }

            int[,] m = new int[rows, cols];
            int[] rowSum = new int[rows];
            int[] colSum = new int[cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                {
                    m[i, j] = rand.Next(1, 101);
                    rowSum[i] += m[i, j];
                    colSum[j] += m[i, j];
                }

            Console.WriteLine("\nМатрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++) Console.Write($"{m[i, j],4}");
                Console.WriteLine($" | Сумма: {rowSum[i]}");
            }

            Console.WriteLine(new string('-', cols * 4 + 10));
            for (int j = 0; j < cols; j++) Console.Write($"{colSum[j],4}");
            Console.WriteLine();

            // Поиск макс/мин строка
            int maxRow = 0, minRow = 0;
            for (int i = 1; i < rows; i++)
            {
                if (rowSum[i] > rowSum[maxRow]) maxRow = i;
                if (rowSum[i] < rowSum[minRow]) minRow = i;
            }

            // Поиск макс/мин столбец
            int maxCol = 0, minCol = 0;
            for (int j = 1; j < cols; j++)
            {
                if (colSum[j] > colSum[maxCol]) maxCol = j;
                if (colSum[j] < colSum[minCol]) minCol = j;
            }

            Console.WriteLine($"\nМакс. сумма строки: {maxRow + 1} ({rowSum[maxRow]})");
            Console.WriteLine($"Мин. сумма строки: {minRow + 1} ({rowSum[minRow]})");
            Console.WriteLine($"Макс. сумма столбца: {maxCol + 1} ({colSum[maxCol]})");
            Console.WriteLine($"Мин. сумма столбца: {minCol + 1} ({colSum[minCol]})");
            WaitForKey();
        }

        static void Task4_2()
        {
            Console.Write("Размер массива: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0) { Console.WriteLine("Ошибка."); WaitForKey(); return; }

            int[] arr = new int[n];
            for (int i = 0; i < n; i++) arr[i] = rand.Next(1, 101);

            Console.WriteLine("Исходный: [" + string.Join(", ", arr) + "]");

            for (int i = 0; i < n / 2; i++)
            {
                int t = arr[i];
                arr[i] = arr[n - 1 - i];
                arr[n - 1 - i] = t;
            }

            Console.WriteLine("Перевёрнутый: [" + string.Join(", ", arr) + "]");
            WaitForKey();
        }

        static void Task4_3()
        {
            Console.Write("Размер массива: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0) { Console.WriteLine("Ошибка."); WaitForKey(); return; }

            int[] orig = new int[n];
            for (int i = 0; i < n; i++) orig[i] = rand.Next(-100, 101);

            Console.WriteLine("Исходный: [" + string.Join(", ", orig) + "]");

            int pos = 0, neg = 0;
            foreach (int x in orig) { if (x > 0) pos++; else if (x < 0) neg++; }

            int[] posArr = new int[pos];
            int[] negArr = new int[neg];
            int pi = 0, ni = 0;
            foreach (int x in orig)
            {
                if (x > 0) posArr[pi++] = x;
                else if (x < 0) negArr[ni++] = x;
            }

            Console.WriteLine("Положительные: [" + (pos > 0 ? string.Join(", ", posArr) : "пусто") + "]");
            Console.WriteLine("Отрицательные: [" + (neg > 0 ? string.Join(", ", negArr) : "пусто") + "]");
            WaitForKey();
        }

        // Блок 5. Задачи
        static void Task5_1()
        {
            Console.Write("n = ");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                Console.WriteLine($"{n}! = {Factorial(n)}");
            }
            else
            {
                Console.WriteLine("n должно быть >= 0.");
            }
            WaitForKey();
        }

        static void Task5_2()
        {
            int[] test = { 10, 20, 30, 40 };
            Console.WriteLine($"Массив: [{string.Join(", ", test)}]");
            Console.WriteLine($"Рекурсивная сумма: {Sum(test)}");
            WaitForKey();
        }

        static void Task5_3()
        {
            Console.Write("Делимое: ");
            if (!int.TryParse(Console.ReadLine(), out int a)) { Console.WriteLine("Ошибка."); WaitForKey(); return; }
            Console.Write("Делитель: ");
            if (!int.TryParse(Console.ReadLine(), out int b) || b == 0) { Console.WriteLine("Делитель ≠ 0."); WaitForKey(); return; }

            Divide(a, b, out int q, out int r);
            Console.WriteLine($"{a} / {b} = {q}, остаток {r}");
            WaitForKey();
        }

        static void Task5_4()
        {
            Console.WriteLine("Пример:(1,2,3,4,5,6,7,8,9,10)");
            int[] evens = FilterEven(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine("Результат: [" + string.Join(", ", evens) + "]");
            WaitForKey();
        }

        // Функции для 5 блока
        static long Factorial(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        static long Sum(int[] arr, int i = 0) => i >= arr.Length ? 0 : arr[i] + Sum(arr, i + 1);


        static void Divide(int dividend, int divisor, out int quotient, out int remainder)
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }

        static int[] FilterEven(params int[] nums)
        {
            int count = 0;
            foreach (int x in nums) if (x % 2 == 0) count++;
            int[] res = new int[count];
            int j = 0;
            foreach (int x in nums) if (x % 2 == 0) res[j++] = x;
            return res;
        }
    }
}

   