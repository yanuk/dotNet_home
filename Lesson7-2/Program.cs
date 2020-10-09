using System;

namespace Lesson7_2
{
    /* Используя Visual Studio, создайте проект по шаблону Console Application.
      Напишите программу, которая будет выполнять конвертирование валют.
      Пользователь вводит:
      сумму денег в определенной валюте.
      курс для конвертации в другую валюту.
      Организуйте вывод результата операции конвертирования валюты на экран. */

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите сумму валюты");
            double summa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Курс валюты: ");
            double kurs = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine ($"\n\n\n\n\n За {summa} единиц валюты Вы получите : {kurs*summa}\n\n\n\nn\n\n\n ");
        }
    }    
}
