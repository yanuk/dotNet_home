
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

        static int InputOnlyNumber(string str1)
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
            int width = InputOnlyNumber("ширину");
            int high = InputOnlyNumber("высоту");

            Console.Clear();

            int startX = 0, startY = 0;




            //Прорисовка прямоугольника.
            for (int y = 0; y < high; y++)
            {
               for (int i = 0; i < width; i++)
                { 
                    Console.SetCursorPosition(i , y );
                    Console.WriteLine("*");
                }
            }


            int yMax = Console.WindowHeight - high;
            int xMax = Console.WindowWidth - width;


            for (; ; )

            {
                
                //Проверка, какая нажата клавиша.

                ConsoleKey keyPressed = Console.ReadKey(true).Key;
                
                if (keyPressed == ConsoleKey.LeftArrow)
                {

                    for (int y = 0; y < high; y++)
                    {
                        if (startX > xMax) startX = xMax;
                        if (startX < 1) startX = 1;
                                               
                        Console.SetCursorPosition(20, 0);
                        Console.WriteLine($"startX = {startX} startY = {startY} ");

                        Console.SetCursorPosition(startX-1, startY + y);
                        Console.WriteLine("*");
                        Console.SetCursorPosition(startX +width-1, y + startY);
                        Console.WriteLine(" ");
                    }
                    startX--;
                    if (startX < 0) startX = 1;
                }


                if (keyPressed == ConsoleKey.RightArrow)
                {
                    
                   for (int i = 0; i < high; i++)
                 {
                        if (startX > (xMax - 1)) startX = xMax - 1;

                        Console.SetCursorPosition(20, 0);
                        Console.WriteLine($"startX = {startX} startY = {startY} ");

                        Console.SetCursorPosition(startX, startY + i);
                        Console.WriteLine(" ");
                        Console.SetCursorPosition((startX + width), (i + startY));
                        Console.WriteLine("*");
                 }
                    startX++;
                    //if (startX > xMax) startX = xMax;
                    if (startX > xMax) break;

                    Console.SetCursorPosition(20,0);
                    Console.WriteLine($"startX = {startX} startY = {startY} high= {high}");
                }


                if (keyPressed == ConsoleKey.UpArrow)
                {
                   
                    if (startY < 0) startY = 0;
                    
                    for (int i = 0; i < width; i++)
                    {
                        Console.SetCursorPosition(20, 0);
                        Console.WriteLine($"startX = {startX} startY = {startY} ");

                        Console.SetCursorPosition (startX+i, startY);
                         Console.WriteLine("*");
                         Console.SetCursorPosition(startX+i, startY + high);
                        Console.WriteLine(" ");
                    }

                   startY--;
                   if (startY < 0) startY = 0;
                }
                                               
                if (keyPressed == ConsoleKey.DownArrow)
                {
                   for (int i = 0; i < width; i++)
                    {
                        Console.SetCursorPosition(i + startX, startY);
                        Console.WriteLine(" ");
                        Console.SetCursorPosition(i + startX, startY+high);
                        Console.WriteLine("*");
                    }

                   startY++;
                   if (startY > yMax-1) startY = yMax;

                    Console.SetCursorPosition(20, 0);
                    Console.WriteLine($"startX = {startX} startY = {startY} ");
                }
                                              
                if (keyPressed == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}