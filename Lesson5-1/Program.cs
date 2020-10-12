using System;
using System.Reflection;

namespace Lesson5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool checkIfNumber(string str)
            //Проверка введено число или текст. 
            {
                for (int i = 0; i < str.Length; i++)
                {
                    {
                        if (char.IsDigit(str[i]) == true)
                        {
                            //введено число
                            return (true);
                        }
                    }
                }
                //введено не число
                return (false);
            }
            /* Задание 2
                  Известно, что у четных чисел младший бит имеет значение 0.
                  Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
                  Напишите программу, которая будет выполнять проверку чисел на четность.
                  Предложите два варианта решения поставленной задачи.
            */
            Console.Clear();
            Console.WriteLine("Введите число :");
            string str = Console.ReadLine();

            if (checkIfNumber(str))
            {
                byte number = Convert.ToByte(str);
                byte port = (byte)(number & 0x01);
                if (port == 0)
                {
                    Console.WriteLine($"Четное число");
                }
                else
                    Console.WriteLine($"Нечетное число");
            }
            else
                Console.WriteLine("Вы ввели не число");
        }
    }
}