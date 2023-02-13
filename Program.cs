/***************************
*Name: Roman Imamov        *
*Group: PI-221             *
*Lab number 1              *
***************************/

using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args) {

            while (true) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter a choise number: 1 is Power, 2 is Transform number, 3 is exit: ");
                int choice = int.Parse(Console.ReadLine());
            
                switch (choice) {
                    case 1:
                        Power();
                        break;

                    case 2:
                        TransformNumber();
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Clear console? (y/n): ");
                string variant = Console.ReadLine();
                if (variant == "y") {
                    Console.Clear();
                }
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }

        private static void Power() {//объявление нового подкласса

            Console.WriteLine("Enter a real number (a):");
            double number = int.Parse(Console.ReadLine());
            //number = a;

            Console.WriteLine("Enter an integer (n):");
            double degree = int.Parse(Console.ReadLine());
            //degree = n;

            double power = 1;

            //Используем цикл для умножения result на number degree раз
            /*for (int index = 0; index < degree; ++index)
            {
                power *= number;
            }*/
            power = Math.Round(Math.Exp(degree * Math.Log(number)));

            Console.WriteLine("a^n = " + power);//Вывод результата
            Console.ReadKey();
        }

        private static void TransformNumber() {

            Console.WriteLine("Enter a real number (x >= 100 ):");

            string number = Console.ReadLine();


            if (number.Length >= 2) {

                string firstChar,
                       secondChar,
                       restOfString;

                firstChar = number[0].ToString();
                //копирование первого символа
                secondChar = number[1].ToString();
                //копирование второго символа
                restOfString = number.Substring(2);
                //копирование всех символов, начиная с третьего

                Console.WriteLine(firstChar + restOfString + secondChar);
                //первый символ + все символы, начиная с третьего + второй символ
            }
            else {
                Console.WriteLine("Error. The number (x) < 100.");
            }
        }
    }
}
