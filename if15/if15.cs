using System;

namespace if15
{
    class if15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа Караевой Вика 2-1ИС:");
            //Даны три числа. Найти сумму двух наибольших из них.
            double ch1 = 0; //объявление переменных типа double
            double ch2 = 0;
            double ch3 = 0;
          

            bool noError = true;

            while (noError)
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
                    Console.WriteLine("ошибка, введите число!");//вывод на экран сообщения
                }
            }


            if ((ch1 < ch2) & (ch1 < ch3)) //проверка условия
            {
                Console.WriteLine("их сумма= " + (ch2 + ch3));
            }

            else if ((ch2 < ch3) & (ch2 < ch1))
            {
                Console.WriteLine("их сумма= " + (ch1 + ch3));
            }
            else Console.WriteLine("их сумма= " + (ch1 + ch2));
            {

            }
         

            Console.WriteLine("Нажмите enter, чтобы выйти");
            Console.ReadKey(); //выходим из программы
        }
    }
}
