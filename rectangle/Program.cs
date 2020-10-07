
using System;

namespace rectangle
{
    class Program
    {
        static int checkIfNumber(string str)
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




        static void Main(string[] args)
        {
            int width = 0;
            int flag = 0;

            while (flag == 0)
            {
                Console.Clear();
                Console.WriteLine("Введите ширину");
                string str = Console.ReadLine();     // Проверка, введено ли число, а не буквы.
                flag = checkIfNumber(str);

                if (flag == 1)
                {
                    width = int.Parse(str);
                    break;
                }
            }
            int high = 0;
            flag = 0;
            while (flag == 0)
            {
                Console.Clear();
                Console.WriteLine("Введите высоту");
                string str = Console.ReadLine();
                flag = checkIfNumber(str);             // Проверка, введено ли число, а не буквы.


                if (flag == 1)
                {
                    high = int.Parse(str);
                    break;
                }
            }

            Console.Clear();


            int startX = 0;
            int startY = 0;


            for (; ; )
            {
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


                if (keyPressed == ConsoleKey.Escape)
                {
                    break;
                }
                Console.Clear();
            }

        }
    }
}
