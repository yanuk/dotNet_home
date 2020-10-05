using System;
using System.Security.Cryptography;

namespace checkNumberOrText
{
    class Program
    {
        static int checkIfNumber (string str)
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
                    Console.WriteLine("Could you please inter the 1-st number");
                    string number = Console.ReadLine();
           
            int flag=  checkIfNumber (number);


            if (flag == 1) Console.WriteLine($"Number= {number}");
                    else
        
                Console.WriteLine($"Вы ввели не цифру");
        }


    }
}


