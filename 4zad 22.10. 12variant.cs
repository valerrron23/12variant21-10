using System;
namespace ConsoleApplication2
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("�����: "); //��������� ������ ������������ ������ ���������� ���������� ����
            string author = Console.ReadLine(); //� ��������� ������� ������
            Console.WriteLine($"����� {author}"); //����� ������
            if (author.Contains("������")) //����
            {
                Console.WriteLine("�������: ���� � �������� ���� "); //����� ������
                }
                if (author.Contains("��������")) //����
                {
                    Console.WriteLine("�������: ������� ����� "); //����� ������
                    }
                    if (!(author.Contains("������")) && !(author.Contains("��������"))) //����
                    {
                        Console.WriteLine("��� ������ � ��������"); //����� ������
                        }
                        Console.ReadLine(); // ��������� ��� ������� ������������ ������� Enter ����� �����������
        }
    }
}