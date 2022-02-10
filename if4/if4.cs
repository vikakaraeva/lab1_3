using System;

namespace if4
{
    class if4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа Караевой Вика 2-1ИС:");
            //Даны три целых числа. Найти количество положительных чисел в исходном наборе.

            int ch1 = 0; //объявление переменных типа int(целые)
            int ch2 = 0;
            int ch3 = 0;
            int Kol = 0;

            bool noError = true; // введём булевую переменную для цикла while

            while (noError) // цикл while для try-catch: если ввели с клавиатуры НЕ число, то возвращаемся обратно
            {
                try
                {
                   Console.WriteLine("введите три целых числа:");  //ввод данных
                    ch1 =int.Parse(Console.ReadLine());
                   ch2= int.Parse(Console.ReadLine());
                   ch3= int.Parse(Console.ReadLine());
                   noError = false;
                }
                catch
                {
                    Console.WriteLine("ошибка, введите целое число!"); // если ввели не то число, то выводим сообщение об ошибке
                }
            }
            if (ch1 > 0) //проверка условия : если чисто положительно, то считаем количество
            {
                Kol = Kol + 1; 
            }
            if (ch1 > 0) 
            {
                Kol = Kol + 1;
            }
            if (ch3 > 0) 
            {
                Kol = Kol + 1;
            }
            Console.WriteLine("количество положительных чисел:"+Kol); //вывод результата

            Console.WriteLine("Нажмите enter, чтобы выйти");
            Console.ReadKey(); //выходим из программы
        }
    }
}
