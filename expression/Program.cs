using Microsoft.VisualBasic.CompilerServices;
using System;

namespace expression
{
    class Program
    {
        static void Main(string[] args)
        {


            string myDay = Console.ReadLine();

            string day = myDay switch

            {
                "понедельник" => "1",
                "вторник" => "2",
                "среда" => "3",
                "четверг" => "4",
                "пятница" => "5",
                "суббота" => "6",
                "воскресенье" => "7",
                _ => "-1"
            };


            if (Convert.ToInt32(day) > 0 && Convert.ToInt32(day) <8 )
            
            Console.WriteLine($"{ day} день неделм");
        


            else
         
       Console.Write("нет такого дня недели");

                Console.Read();
       }
    }
}
