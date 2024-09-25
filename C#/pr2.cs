namespace pr2.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            double a, b, result;
            Console.WriteLine("Введите первое число:");
            str = Console.ReadLine();
            a = Convert.ToDouble(str);
            Console.WriteLine("Введите второе число:");
            str = Console.ReadLine();
            b = Convert.ToDouble(str);
            Console.WriteLine("Введите опреацию:+, -, /, *");
            char operation = Convert.ToChar(Console.ReadLine());
            result = Convert.ToDouble(str);

            if (operation == '+')
            {
                result = a + b;
                Console.WriteLine("Сумма чисел равна:" + result);
                Console.ReadKey();
            }
            else if (operation == '-')
            {
                result = a - b;
                Console.WriteLine("Разность чисел равна:" + result);
                Console.ReadKey();
            }
            else if (operation == '*')
            {
                result = a * b;
                Console.WriteLine("Произведение чисел равна:" + result);
                Console.ReadKey();
            }
            else if (operation == '/')
            {
                if (b != 0)
                {
                    result = a / b;
                    Console.WriteLine("Деление чисел равна:" + result);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine(" На ноль делить нельзя!");
                    Console.Readkey();
                }

            }
           
        }
    }
}
