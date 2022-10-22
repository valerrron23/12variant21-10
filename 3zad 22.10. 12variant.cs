using System;
namespace ConsoleApplication2
{
    class Program
    {
        private static void Main(string[] args)
        {
        Console.WriteLine("Введите X="); //программа просит пользователя ввести переменную вещественного типа
        int x = int.Parse(Console.ReadLine()); //в программу введены данные

        Console.WriteLine("Введите Y="); //программа просит пользователя ввести переменную вещественного типа

        int y = int.Parse(Console.ReadLine()); //в программу введены данные

        if (x > 40 && x > -40 && y > 40 && y > -40) //если 
            Console.WriteLine("Точка лежит в заштрихованной области"); //вывод данных
        else if (x == 40 || y == 40 || x == -40 || y == -40) //иначе 
            Console.WriteLine("Точка лежит на границе области"); //вывод данных
        else
            Console.WriteLine("Точка НЕ лежит в заштрихованной области"); //вывод данных
        }
    }
}