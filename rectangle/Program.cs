using System;

namespace rectangle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите ширину");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите высота");
            int high = int.Parse(Console.ReadLine());       

            Console.Clear ();
            
            for (int i = 0; i < width; i++)
            {
               for (int y=0; y < high; y++)
             {
                    Console.SetCursorPosition(i, y);
                    Console.WriteLine("*");
               }
            }

            
        }
    }
}
