using System;
using System.Runtime.CompilerServices;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Используя VStudio,создайте проект по шаблону Console Application. Напишите программу -консольный калькулятор.
            // Создайте две переменные с именами operand1 и operand2. Задайте переменным некоторые произвольные значения.
            // Предложите пользователю ввести знак арифметической операции. Примите значение, введенное пользователем, 
            // и поместите его в строковую переменную sign. Для организации выбора алгоритма вычислительного процесса, 
            // используйте переключатель switch.Выведите на экран результат выполнения арифметической операции.
            // В случае использования операции деления, организуйте проверку попытки деления на ноль. 
            // И если таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке пользователя.

            Console.WriteLine("Консольный калькулятор");

            Console.WriteLine("Please, enter operand 1 :");

            string operand1 = Console.ReadLine();

            string operand2= "-1";
            
            while (operand2 == "-1")
            {
                Console.WriteLine("Please, enter operand 2 :");
                operand2 = Console.ReadLine();
                                
                if (operand2 == "0")
                {
                    Console.WriteLine("Попытка деления на ноль.");
                    Console.WriteLine("Введите другое значение");
                    operand2 = "-1";
                }

            }
            
            int sign = -1;

            while (sign == -1)
            {
                Console.WriteLine("Please, enter: + or - or * or / or ^ ");
                string action = Console.ReadLine();

                   sign = action switch
                {
                    "+" => Convert.ToInt32 (operand1) + Convert.ToInt32 (operand2),
                    "-" => Convert.ToInt32(operand1) - Convert.ToInt32(operand2),
                    "*" => Convert.ToInt32(operand1) * Convert.ToInt32(operand2),
                    "/" => Convert.ToInt32 (operand1) / Convert.ToInt32 (operand2),
                    "^" => Convert.ToInt32(operand1) ^ Convert.ToInt32(operand2),
                    _ => -1
                 };
                if (sign != -1)
                {
                Console.WriteLine($"{operand1} {action}  {operand2} =  {sign}");
                }
                else
                Console.ReadLine();
              }
        }
    }
}





