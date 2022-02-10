using System;

namespace if12
{
    class if12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа Караевой Вика 2-1ИС:");
            //Даны три числа.Найти наименьшее из них.


            double ch1 = 0;//объявление переменных типа double
            double ch2 = 0;
            double ch3 = 0; 
            bool noError = true; // введём булевую переменную для цикла while

            while (noError) // цикл while для try-catch: если ввели с клавиатуры НЕ число, то возвращаемся обратно
            {
                try
                {
                    Console.WriteLine("введите три числа: "); //ввод переменных
                    ch1 = double.Parse(Console.ReadLine());
                    ch2 = double.Parse(Console.ReadLine());
                    ch3 = double.Parse(Console.ReadLine());
                    noError = false;
                }
                catch
                {
                    Console.WriteLine("ошибка, введите число!");// если ввели буквы и тд, то выводим сообщение об ошибке
                }
            }
            if (ch1 > ch2)//проверка условия
            {
                ch1 = ch2;
            }
            else
            {
                ch2 = ch1;
            }
            if (ch2 > ch3)
            {
                ch2 = ch3;
            }
            else
            {
                ch3 = ch2;
            }
            Console.Write("наименьшее число: " + ch2); //вывод результата
            Console.WriteLine("Нажмите enter, чтобы выйти");
            Console.ReadKey(); //выходим из программы
        }
    }
}
