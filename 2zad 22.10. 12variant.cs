using System;
namespace ConsoleApplication2
{
    class Program
    {
        private static void Main(string[] args)
        {
         Console.Write("������� ���������� �����: "); //��������� ������ ������������ ������ ���������� ������������� ����
            char[] number = Console.ReadLine().ToCharArray(); //� ��������� ������� ������
            Console.Write("������� �: "); //��������� ������ ������������ ������ ���������� ������������� ����
            int A = int.Parse(Console.ReadLine()); //� ��������� ������� ������
            int mod = (int.Parse(number[0].ToString()) + int.Parse(number[1].ToString())) % A; //� ��������� ������� ������
            if(mod == 0) //����
                Console.WriteLine("����� ������"); //����� ������
            else //�����
                Console.WriteLine("����� �� ������"); //����� ������
            Console.ReadKey();
        }
    }
}