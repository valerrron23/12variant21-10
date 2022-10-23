using System;
namespace ConsoleApplication2
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Автор: "); //программа просит пользователя ввести переменную строкового типа
            string author = Console.ReadLine(); //в программу введены данные
            Console.WriteLine($"Автор {author}"); //вывод данных
            if (author.Contains("Шишкин")) //если
            {
                Console.WriteLine("Картина: Утро в сосновом лесу "); //вывод данных
                }
                if (author.Contains("Левиатан")) //если
                {
                    Console.WriteLine("Картина: Золотая осень "); //вывод данных
                    }
                    if (!(author.Contains("Шишкин")) && !(author.Contains("Левиатан"))) //если
                    {
                        Console.WriteLine("Нет картин в каталоге"); //вывод данных
                        }
                        Console.ReadLine(); // Программа ждёт нажатия пользователя клавиши Enter перед завершением
        }
    }
}
