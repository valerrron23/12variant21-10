usinusing System;
namespace ConsoleApplication2
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите Х="); //программа просит пользователя ввести переменную вещественного типа
            double x = double.Parse(Console.ReadLine()); //в программу введены данные
            
            double y = 0; //значение y принимает ноль
            
            if (x > 6.7) //если значение х принимает больше 6,7 то
            
            {
                y = 4 - Math.Pow(Math.E, 4*x); //программа вычисляет по формуле
                
            }
            else //иначе
            {
                y = Math.Log10(3.5 + x); //программа вычисляет по формуле
                
            }
            Console.WriteLine("Результат Y={0}", y); //вывод данных
        }
    }
}