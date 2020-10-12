using System;

namespace lesson4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 0 до 100 ");
            int numberFrom0To100 = Convert.ToInt32(Console.ReadLine());
            if (numberFrom0To100 > 49 && numberFrom0To100 < 101) Console.WriteLine("Промежуток от 50 до 100");
            if (numberFrom0To100 > 36 && numberFrom0To100 < 49) Console.WriteLine("Промежуток от 35 до 50");
            if (numberFrom0To100 > 15 && numberFrom0To100 < 36) Console.WriteLine("Промежуток от 15 до 35");
            if (numberFrom0To100 >= 0 && numberFrom0To100 < 16) Console.WriteLine("Промежуток от 0 до 15");
            if (numberFrom0To100 < 0 || numberFrom0To100 > 100) Console.WriteLine("Число не входит ни в один из имеющихся числовых промежутков");
        }
    }
}
