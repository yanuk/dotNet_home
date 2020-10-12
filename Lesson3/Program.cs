using System;
using System.Numerics;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 12;
            int z = 3;
            double average;

            x += y - x++ * z;
            Console.WriteLine(x);
            z = --x - y * 5;
            Console.WriteLine(z);
            y /= x + 5 % z;
            Console.WriteLine(y);
            z = x++ + y * 5;
            Console.WriteLine(z);
            x = y - x++ * z;
            Console.WriteLine(x);
            Console.ReadLine();

            // Задание 2.
            //Используя Visual Studio, создайте проект по шаблону Console Application.
            //Вычислите среднее арифметическое трех целочисленных значений и выведите его на экран.
            //С какой проблемой вы столкнулись? Какой тип переменных лучше использовать для корректного отображения результата
            x = 10;
            y = 6;
            z = 12;
            average = ((double)x + (double)y + (double)z) / 3; ;
            Console.WriteLine(average);

            //Задание 3
            //Используя Visual Studio, создайте проект по шаблону Console Application.
            //Создайте константу с именем -pi(число π «пи»), создайте переменную радиус с именем – r.Используя
            //формулу πR2, вычислите площадь круга и выведите результат на экран.

            double radius = 12;
            double pi = 3.14159;
            double areaOfTheCircle;
            areaOfTheCircle = pi * radius * radius;
            Console.WriteLine("\nРадиус: {0} \nПлощадь круга: {1}", radius, areaOfTheCircle);
            Console.ReadLine();



            // Задание 4

            //Используя Visual Studio, создайте проект по шаблону Console Application.
            //Напишите программу расчета объема – V и площади поверхности – S цилиндра.
            //Объем V цилиндра радиусом – R и высотой – h, вычисляется по формуле: V = πR2h
            //Площадь S поверхности цилиндра вычисляется по формуле: S = 2πR2 h +2πR2 = 2πR(R + h)

            double volumeCilinder = 0, areaSurface = 0;
            int radiusCililinder = 10, highCilinder = 15;
            areaSurface = pi * radiusCililinder * radiusCililinder * highCilinder;
            volumeCilinder = pi * radiusCililinder * radiusCililinder * highCilinder;

            Console.WriteLine("\nОбъем V цилиндра {0} \nПлощадь поверхности: {1}", radius, areaOfTheCircle);





        }
    }
}
