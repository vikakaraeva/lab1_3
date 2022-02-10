using System;

namespace if24
{
    class if24
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа Караевой Вика 2-1ИС:");
            //Для данного вещественного x найти значение следующей функции f, принимающей вещественные значения

            float number = 0; //объявление переменной типа float
            bool noError = true; //введём булевую переменную для цикла while

            Console.Write("введите число: ");  //ввод переменных
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
            if (number > 0) //проверка условия
            {
                Console.WriteLine($"F(x)= {2 * Math.Sin(number)}"); //функция: возвращает синус указанного угла.
            }
            else
            {
                Console.WriteLine($"F(x)= {6 - number}");
            }

            Console.WriteLine("Нажмите enter, чтобы выйти");
            Console.ReadKey(); //выходим из программы
        }
    }
}
