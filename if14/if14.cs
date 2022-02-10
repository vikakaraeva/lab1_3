using System;

namespace if14
{
    class if14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа Караевой Вика 2-1ИС:");
            //Даны три числа. Вывести вначале наименьшее, а затем наибольшее из данных чисел.

            double ch1 = 0;//объявление переменных типа double
            double ch2 = 0;
            double ch3 = 0;
            double min = 0;
            double max = 0;
            bool noError = true; // введём булевую переменную для цикла while

            while (noError)// цикл while для try-catch: если ввели с клавиатуры НЕ число, то возвращаемся обратно
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
           
            if ((ch1 < ch2) & (ch1 < ch3)) //проверка условия
            {
                min = ch1;
            }


            if ((ch2 < ch1) & (ch2<ch3))
            {
                min = ch2;
            }

            if ((ch3 < ch1) & (ch3 < ch2))
            {
                min = ch3;
            }

            if ((ch1 > ch2) & (ch1 > ch3))
            {
                max = ch1;
            }

            if ((ch2 > ch1) & (ch2 > ch3))
            {
                max = ch2;
            }

            if ((ch3 > ch1) & (ch3 > ch2))
            {
                max = ch3;
            }



            Console.WriteLine("наименьшее число: " + min); //вывод результата
            Console.WriteLine("наибольшее число: " + max);

            Console.WriteLine("Нажмите enter, чтобы выйти");
            Console.ReadKey(); //выходим из программы
        }
    }
}
