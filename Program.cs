using System.IO.Pipes;

namespace clac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите дальнейшее действие:");
            Console.WriteLine("1.Сложение  \n 2.Вычетание  \n 3.Умножение \n 4.Деление \n 5.Возведение в степень \n 6.Нахождение квадратного корня \n 7.1% от числа \n 8.Нахождение факториала \n 9. Выход из калькулятора ");

            string operation = Console.ReadLine();
            int num = Convert.ToInt32(operation);

            Console.WriteLine("Введите первое число: ");
            string input = Console.ReadLine();
            int num1 = Convert.ToInt32(input);

            Console.WriteLine("Введите второе число: ");
            string inputOne = Console.ReadLine();
            int num2 = Convert.ToInt32(inputOne);



            do
            {

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Результат сложения " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Результат вычетания " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Результат умножения " + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("Результат диления " + (num1 / num2));
                        break;
                    case 5:
                        Console.WriteLine("Результат возведения в степень " + (Math.Pow(num1, num2)));
                        break;
                    case 6:
                        Console.WriteLine("Результат вычесление квадратного корня " + (Math.Sqrt(num1)));
                        break;
                    case 7:
                        Console.WriteLine("Результат нахождения 1% " + (num1 * 0.01));
                        break;
                    case 8:
                        int fact = 1;
                        for (int i = 0; i <= num1; i++)
                        {
                            fact *= i;
                        }
                        Console.WriteLine("Результат нахождения факториала " + (fact));
                        break;

                }
                num = Convert.ToInt32(Console.ReadLine());
            } while (num != 9);



        }
    }
}