using System;

namespace if3
{
    class if3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа Караевой Вика 2-1ИС:");
            //Дано целое число. Если оно является положительным, то вычесть из него 8; если отрицательным, то прибавить к нему 6;
            //если нулевым, то заменить его на 10. Вывести полученное число.


            int chislo = 0; // объявление переменных типа int (целочисленный)
            bool noError = true; // введём булевую переменную для цикла while

            while (noError) // цикл while для try-catch: если ввели с клавиатуры НЕ число, то возвращаемся обратно
            {
                try
                {
                    Console.WriteLine("введите целое число:"); //ввод данных
                    chislo = int.Parse(Console.ReadLine());
                    noError = false;
                }
                catch
                {
                    Console.WriteLine("ошибка, введите целое число!"); // если ввели не то число, то выводим сообщение об ошибке
                }
            }
            if (chislo > 0) //проверка условия:если число больше 0, то вычитаем из числа 8
            {
                chislo = chislo - 8;
            }
            else if (chislo < 0)
            {
                chislo = chislo + 6; // если число меньше 0, то складываем к числу 6
            }
            else if (chislo == 0) // если число равно 0, то число становится равным 10
            {
                chislo = 10;
            }
            Console.WriteLine("число=" + chislo); //вывод результата

            Console.WriteLine("Нажмите enter, чтобы выйти");
            Console.ReadKey(); //выходим из программы
        }
    }
}
