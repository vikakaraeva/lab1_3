using System;

namespace if30
{
    class if30
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа Караевой Вика 2-1ИС:");
            // Дано целое число, лежащее в диапазоне 1–999. Вывести его строку-описание вида «четное двузначное число», «нечетное трехзначное число» и т. д.

            int number = 0; //объявление переменных типа int
            bool noError = true; // введём булевую переменную для цикла while

            Console.Write("введите число: "); //ввод переменных
            while (noError) // цикл while для try-catch: если ввели с клавиатуры НЕ число, то возвращаемся обратно
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    noError = false;
                }
                catch
                {
                    Console.WriteLine("ошибка, введите число!"); // если ввели буквы и тд, то выводим сообщение об ошибке
                }
            }
                if (number == 0) {
                    Console.Write("нейтральное ");
                }
                else 
    
                if (number % 2 == 0) //проверка условия
                {
                    Console.Write("четное ");
                }
                else
                {
                    Console.Write("нечетное ");
                }

                if (number / 100 > 0 && number / 100 < 10)
                {
                    Console.WriteLine("трёхзначное число");
                }
                else
                if (number / 10 > 0 && number / 10 < 10)
                {
                    Console.WriteLine("двузначное число");
                }
                else
                if (number / 10 == 0)
                {
                    Console.WriteLine("однозначное число");
                }
            
        
            Console.WriteLine("Нажмите enter, чтобы выйти");
            Console.ReadKey(); //выходим из программы
        }
    }
}
