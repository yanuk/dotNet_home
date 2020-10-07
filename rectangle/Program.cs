
using System;
using System.ComponentModel.Design;

namespace rectangle
{
    class Program
    {
        static int CheckIfNumber(string str)
        //Проверка введено число или текст. 
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]) == false)
                {
                    //введен текст
                    return 0;
                }
            }
            //введено число
            return 1;
        }

        static int InputOnlyNumber (string str1)
        {
            
            int flag1 = 0, numberInt = 0;

            while (flag1 == 0)
            {
                Console.Clear();
                Console.WriteLine($"Введите {str1}");
                string str = Console.ReadLine();     // Проверка, введено ли число, а не буквы.
                flag1 = CheckIfNumber(str);

                if (flag1 == 1 && str != "")
                   numberInt = int.Parse(str);
                else
                    flag1 = 0;
            }
            return (numberInt);
        }
              static void Main(string[] args)
            {
                   int width = InputOnlyNumber  ("ширину");
                   int high  = InputOnlyNumber ("высоту");
             
                   Console.Clear();

                   int startX = 0, startY = 0;

                for (; ; )
                {
                    //Прорисовка прямоугольника.
                    for (int i = 0; i < width; i++)
                    {
                        for (int y = 0; y < high; y++)
                        {
                            Console.SetCursorPosition(i + startX, y + startY);
                            Console.WriteLine("*");
                        }
                    }

                    Console.SetCursorPosition(0, 0);
                    int yMax = Console.WindowHeight - high;
                    int xMax = Console.WindowWidth - width;

                    //Проверка, какая нажата клавиша.

                    ConsoleKey keyPressed = Console.ReadKey(true).Key;

                    if (keyPressed == ConsoleKey.LeftArrow)
                    {
                        startX--;
                        if (startX < 0) startX = 0;
                    }

                    if (keyPressed == ConsoleKey.RightArrow)
                    {
                        startX++;
                        if (startX > xMax) startX--;
                    }

                    if (keyPressed == ConsoleKey.UpArrow)
                    {
                        startY--;
                        if (startY < 0) startY = 0;
                    }

                    if (keyPressed == ConsoleKey.DownArrow)
                    {
                        startY++;
                        if (startY > yMax) startY = yMax;
                    }

                    //проверка на выход.
                    if (keyPressed == ConsoleKey.Escape)
                    {
                    Console.Clear();
                        break;
                    }
                    Console.Clear();
                }
            }
        }
    }

