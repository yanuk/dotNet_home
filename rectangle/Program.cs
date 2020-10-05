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
        
            Console.WriteLine("Введите ширину");

            while (flag == 0)
            {
                Console.Clear();
                Console.WriteLine("Введите ширину");
                string str = Console.ReadLine();
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
                flag = checkIfNumber(str);

                
                if (flag == 1)
                {
                   high = int.Parse(str);
                    break;
                }

            }

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
