using System;
using System.ComponentModel.Design;
using System.Transactions;
namespace Lesson7_1
{
    /* Используя Visual Studio, создайте проект по шаблону Console Application.
       Создайте четыре метода для выполнения арифметических операций, с именами: Add – сложение, Sub –
       вычитание, Mul – умножение, Div – деление.Каждый метод должен принимать два целочисленных
       аргумента и выводить на экран результат выполнения арифметической операции соответствующей
       имени метода. Метод деления Div, должен выполнять проверку попытки деления на ноль.
       Требуется предоставить пользователю возможность вводить с клавиатуры значения операндов и знак
       арифметической операции, для выполнения вычислений
    */
    class Program
    {
        static int InputNumber()

        //Метод ввода значения числа типа "int"  с проверкой. 

        {
            bool success = false;

            while (!success)
            {
                Console.Clear();
                Console.WriteLine("Введите число: ");
                string str = Console.ReadLine();

                success = Int32.TryParse(str, out int number);

                if (success)
                {
                    return (number);
                }
            }
            return (0);
        }

        static double Sum(in double firstOperand, in double secondOperand)
        {
            double sum = firstOperand + secondOperand;
            return (sum);
        }
        static double Sub(in double firstOperand, in double secondOperand)
        {
            double sum = firstOperand - secondOperand;
            return (sum);
        }

        static double Mul(in double firstOperand, in double secondOperand)
        {
            double mult = firstOperand * secondOperand;
            return (mult);
        }

        static double Div(in double firstOperand, ref double secondOperand)
        {
            if (secondOperand == 0)
            {
                // проверка знаменателя на 0. Если ноль, то новый ввод числа.
                secondOperand = InputNumber();
            }
            double mult = firstOperand / secondOperand;
            return (mult);
        }

        static void Main(string[] args)
        {
            double firstOperand = Convert.ToDouble(InputNumber());
            double secondOperand = Convert.ToDouble(InputNumber());
            double finalValue = 0;
            string action = "";


            while (action != "+" && action != "-" && action != "*" && action != "/")
            {
                Console.Clear();
                Console.WriteLine($"Введите  + или - или * или /");
                action = Console.ReadLine();
            }

            if (action == "+") finalValue = Sum(firstOperand, secondOperand);
            if (action == "-") finalValue = Sub(firstOperand, secondOperand);
            if (action == "*") finalValue = Mul(firstOperand, secondOperand);
            if (action == "/") finalValue = Div(firstOperand, ref secondOperand);

            Console.Clear();
            Console.WriteLine($"{Environment.NewLine} {Environment.NewLine} {firstOperand} {action} {secondOperand} = {finalValue}");
            Console.WriteLine($"{Environment.NewLine} {Environment.NewLine}{Environment.NewLine}{Environment.NewLine}");
        }
    }
}

