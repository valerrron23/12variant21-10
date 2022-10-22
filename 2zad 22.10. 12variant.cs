using System;
namespace ConsoleApplication2
{
    class Program
    {
        private static void Main(string[] args)
        {
         Console.Write("Введите двузначное число: "); //программа просит пользователя ввести переменную вещественного типа
            char[] number = Console.ReadLine().ToCharArray(); //в программу введены данные
            Console.Write("Введите А: "); //программа просит пользователя ввести переменную вещественного типа
            int A = int.Parse(Console.ReadLine()); //в программу введены данные
            int mod = (int.Parse(number[0].ToString()) + int.Parse(number[1].ToString())) % A; //в программу введены данные
            if(mod == 0) //если
                Console.WriteLine("Число кратно"); //вывод данных
            else //иначе
                Console.WriteLine("Число не кратно"); //вывод данных
            Console.ReadKey();
        }
    }
}
