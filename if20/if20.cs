using System;

namespace if20
{
    class if20
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа Караевой Вика 2-1ИС:");
            //На числовой оси расположены три точки: A, B, C. Определить, какая из двух последних точек (B или C) расположена ближе к A,
            //и вывести эту точку и ее расстояние от точки A.

            int A = 0; //объявление переменных типа int
            int B = 0;
            int C = 0;


            bool noError = true;// введём булевую переменную для цикла while

            while (noError)// цикл while для try-catch: если ввели с клавиатуры НЕ число, то возвращаемся обратно
            {
                try
                {
                    Console.WriteLine("введите координаты трех точек А, В, С: "); //ввод переменных
                    A = int.Parse(Console.ReadLine());
                    B = int.Parse(Console.ReadLine());
                    C = int.Parse(Console.ReadLine());
                    noError = false;
                }
                catch
                {
                    Console.WriteLine("ошибка, введите число!");// если ввели буквы и тд, то выводим сообщение об ошибке
                }
            }
            if ((B - A) > (C - A)) //проверка условия
            {
                Console.WriteLine($"т. B ближе к т.A, расстояние = {Math.Abs(B - A)}"); //функция:возвращает абсолютное значение заданного числа.
            }
            else if ((B - A) < (C - A))
            {
                Console.WriteLine($"т. C ближе к т.А, расстояние = {Math.Abs(C - A)}");
            }
            else
            {
                Console.WriteLine($"B и C - находятся в одной точке, расстояние до т.А = {Math.Abs(B - A)}");

            }
            Console.WriteLine("Нажмите enter, чтобы выйти");
            Console.ReadKey(); //выходим из программы
        }
        }
}

