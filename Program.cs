/***************
 * Lab 5       *
 * Imamov R.R. *
 ***************/

using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Lab_5 {
    class File {
        static void Main(string [] args) {
            Console.Write("The path to the file: ");
            string Path = Console.ReadLine();
            FileInfo fileInfo = new FileInfo(Path);
            if (!fileInfo.Exists) {
                Console.WriteLine("File not found.");
            }
            int UserChoice = 0;
            while (UserChoice != 3) {
                Console.WriteLine("1.Fix phone numbers.\n2. Fix the words.\n3.Exit.");
                while (UserChoice <= 0 || UserChoice >= 4) {
                    if (int.TryParse(Convert.ToString(Console.ReadLine()), out UserChoice) == false) {
                        Console.WriteLine("Unknown command.");
                    }
                }
                Console.Clear();

                switch (UserChoice) {
                    case 1:
                    Console.Clear();
                    EditPhoneNumbers.EditorOfPhoneNumbers(Path);
                    UserChoice = 0;
                    break;
                    case 2:
                    Console.Clear();
                    ChangingWords.SearchingWrongWords(Path);
                    UserChoice = 0;
                    break;
                }

            }
            Console.ReadKey();
        }

    }
}