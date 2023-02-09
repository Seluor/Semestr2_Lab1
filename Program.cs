using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter a choise number:");//Объявление новой (переменной для выбора программы)
            int choice = int.Parse(Console.ReadLine());

            switch (choice)//Выбор выполнения программы
            {
                case 1:
                    Power();
                    break;

                case 2:
                    TransformNumber();
                    break;
            }
        }

        private static void Power()
        {//объявление нового подкласса

            Console.WriteLine("Enter a real number (a):");
            int number = int.Parse(Console.ReadLine());
            //Объявление числа a;

            Console.WriteLine("Enter an integer (n):");
            int degree = int.Parse(Console.ReadLine());
            //Объявление числа n;

            int power = 1;

            // Используем цикл для умножения result на number degree раз
            for (int index = 0; index < degree; ++index)
            {
                power *= number;
            }

            Console.WriteLine("a^n = " + power);//Вывод результата
            Console.ReadKey();
        }

        private static void TransformNumber()
        {


            Console.WriteLine("Enter a real number (x >= 100 ):");

            string number = Console.ReadLine();

            if (number.Length >= 2)
            {
                string firstChar,
                       secondChar, 
                       restOfString;

                firstChar = number[0].ToString();
                secondChar = number[1].ToString();
                restOfString = number.Substring(2);

                Console.WriteLine(firstChar + restOfString + secondChar);
            }
            else
            {
                Console.WriteLine("Error. The number (x) < 100.");
            }

        }
    }
}
