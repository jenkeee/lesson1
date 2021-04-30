using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
      class practic_1
    {        
        //первый вызов программы обязательно static, дальше обязательно убрать. так как статический метод ввода в программу может быть только 1. нельзя включить игру сразу в 500 окнах в одном окне одновременно. условие ложно
        static void Main(string[] args)
        {
            #region задача 1
            // Задача 1. Написать программу сложения двух чисел.
            //хочу доработать её, проверка на вводимые только числа.
            Console.Title = ("Задача 1. Написать программу сложения двух чисел.");
            double first;
            double sec;
            Console.Write("Введите первое число: ");
            string str = Console.ReadLine();
            first = Convert.ToDouble(str);
            Console.Write("Введите второе число: ");
            sec = Convert.ToDouble(Console.ReadLine());
            double z = first + sec;  // создает переменную z в формате double что значит числа со знаками после запятой. можно указать int32, будет приводить к целому
            Console.WriteLine(first + "+" + sec + "=" + z);     // Преобразование в строку
            #endregion
            #region задача 2
            // Задача 2. Вывести значение функции ax^2+bx+c в точке x.x — ввести с клавиатуры, a, b и c — присвоить в программе.
            Console.Title = ("Задача 2. Вывести значение функции");
            double a = 1;
            double b = 2;
            int c = 3;
            double x;
            Console.Write("Введите значение x: ");
            string s = Console.ReadLine();
            x = Convert.ToDouble(s);
            double f = a * Math.Pow(x, 2) + b * x + c;
            Console.WriteLine("f={4}={0}*x^2+{1}*x+{2}, при x={3}", a, b, c, x, f);

            #endregion
            #region задача 3
            // Задача 3.Обменять значениями две переменные.
            Console.Title = ("Задача 3.Обменять значениями две переменные.");
            Console.WriteLine("Давай еще раз посчитаем f при другом значении x, по формуле f={4}={0}*x^2+{1}*x+{2}", a, b, c, x, f);
            Console.WriteLine("Введи новое значение X вместо " + x);
            string newX = Console.ReadLine();
            x = Convert.ToDouble(newX); // записываем новые значения в x с преоброзованием в целое, не работает. принимает только целые x
            a = x; // подставляет вместо а новое Х
            b = c; // подстовляет вместо b новое с
                        Console.WriteLine("а еще в формуле я заменил константу b на константу c, а а прировнял к х, типо так  a = x        b = c, кстати X теперь может быть только целым. ");
            Console.WriteLine("Сейчас получается А = "+ a + "; X = " + x + "; b = " + b);
            #region подсказка
            int ar = 10;     // Присваиваем начальное значение
            int br = 20;     // Присваиваем начальное значение
            a = Convert.ToInt32(ar);
            int t = ar;        // В t запоминаем значение a
            a = b;           // В a записываем b
            b = t;           // В b записываем сохраненное a
            #endregion


            #endregion
            #region задача 4
            Console.Title = ("проверка числа на четность");
            Console.WriteLine("введите число на проверку на четность");
            int number = Convert.ToInt32(Console.ReadLine());  // number переменная
            bool res = mymethod(number);
            Console.WriteLine(res);
            Console.WriteLine();
            #endregion
            #region Задача 5
            // Задача 5. Работа с консолью и перегрузкой методов.

            Print("Привет!\n", number, 20);  // не совсем понял почему 2 раза вызываем одинаковый метод с разными свойствами
            Print("Привет еще раз!", ConsoleColor.Red); // здесь мы вызываем метод которые описали ниже static void Print(string msg, ConsoleColor foregroundcolor)
            Print("напишу синими буквами и сдвину на C тоесть 3, C =."+c, c, 20, ConsoleColor.Blue); // отдельно создавался метод Print / было создано 3 метода
                                                                                                     // 3 принт с разными свойствами и 3 метода были вызваны в консоли. 

            #endregion
            #region 6
            Console.Write("Введите a:");
            double a6 = double.Parse(Console.ReadLine());
            Console.Write("Введите b:");
            double b6 = double.Parse(Console.ReadLine());
            Console.Write("Введите c:");
            double c6 = double.Parse(Console.ReadLine());
            Console.WriteLine("Может существовать треугольник с такими сторонами:" + IsTriangle(a6, b6, c6));
            Console.WriteLine("Площадь треугольника:" + S(a6, b6, c6));
            Console.ReadLine();

            #endregion
            Console.ReadLine();
        }
        #region Дополнительно методы к задачам 
        // задача 6
        static bool IsTriangle(double a6, double b6, double c6)
        {
            return a6 + b6 > c6 && a6 + c6 > b6 && c6 + b6 > a6;
        }

        static double S(double a6, double b6, double c6)
        {
            double p = (a6 + b6 + c6) / 2;
            return Math.Sqrt(p * (p - a6) * (p - b6) * (p - c6));
        }

        // задача 4
        static bool mymethod(int myNum)
        {
            // < > >= <= == !=
            bool res = myNum % 2 == 0;

            return res;  // { return myNum % 2 == 0; } = { bool res = myNum % 2 == 0; return res; }
                         // if res ="true" от этого условия давай скакать
        }
        // задача 5 дополнительные методы
        static void Print(string msg, int x, int y, ConsoleColor foregroundcolor) // тут я описал третий метод добавив помиму msg x y , я добавил консоль колор. надо попрактиковатся с игрой свойств
        {
            
            Console.ForegroundColor = foregroundcolor; // подтягивает цвет из свойства Print("Привет еще раз!", ConsoleColor.Red);
            Console.SetCursorPosition(x, y);// Установим позицию курсора на экране подтянув переменные
            Console.WriteLine(msg); // подтягивает переменную из свойства которое мы вызывали ранее Print("напишу 
        }
        static void Print(string msg, int x, int y)
        {
            // Установим позицию курсора на экране
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        static void Print(string msg, ConsoleColor foregroundcolor)
        {
            // Установим цвет символов
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(msg);
        }


        // Создайте перегрузку функции, в которой будет указана позиция и цвет

        #endregion
    }
}



