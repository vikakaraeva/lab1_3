using System;

namespace if26
{
    class if26
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа Караевой Вика 2-1ИС:");
            // Для данного вещественного x найти значение следующей функции f, принимающей вещественные значения

            float number = 0; //объявление переменной типа float
            bool noError = true; // введём булевую переменную для цикла while

            Console.Write("введите число: "); //ввод переменных
            while (noError) // цикл while для try-catch: если ввели с клавиатуры НЕ число, то возвращаемся обратно
            {
                try
                {
                    number = float.Parse(Console.ReadLine());
                    noError = false;
                }
                catch
                {
                    Console.WriteLine("ошибка, введите число!");// если ввели буквы и тд, то выводим сообщение об ошибке
                }
            }
            if (number <= 0) //проверка условия
            {
                Console.WriteLine($"F(x)= {-number}");
            }
            else
                if (number < 2 && number > 0)
            {
                Console.WriteLine($"F(x)= {Math.Pow(number, 2)}"); //функция: возвращает указанное число, возведенное в указанную степень.
            }

            else
            if (number >= 2)
            {
                Console.WriteLine($"F(x)= 4");
            }
            Console.WriteLine("Нажмите enter, чтобы выйти");
            Console.ReadKey(); //выходим из программы
        }
    }
}
