namespace pr2.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            double a, b, result;
            Console.WriteLine("������� ������ �����:");
            str = Console.ReadLine();
            a = Convert.ToDouble(str);
            Console.WriteLine("������� ������ �����:");
            str = Console.ReadLine();
            b = Convert.ToDouble(str);
            Console.WriteLine("������� ��������:+, -, /, *");
            char operation = Convert.ToChar(Console.ReadLine());
            result = Convert.ToDouble(str);

            if (operation == '+')
            {
                result = a + b;
                Console.WriteLine("����� ����� �����:" + result);
                Console.ReadKey();
            }
            else if (operation == '-')
            {
                result = a - b;
                Console.WriteLine("�������� ����� �����:" + result);
                Console.ReadKey();
            }
            else if (operation == '*')
            {
                result = a * b;
                Console.WriteLine("������������ ����� �����:" + result);
                Console.ReadKey();
            }
            else if (operation == '/')
            {
                if (b != 0)
                {
                    result = a / b;
                    Console.WriteLine("������� ����� �����:" + result);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine(" �� ���� ������ ������!");
                    Console.Readkey();
                }

            }
           
        }
    }
}
