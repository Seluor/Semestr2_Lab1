using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab_5 {
    internal class EditPhoneNumbers {
        public static void EditorOfPhoneNumbers(string Path) {
            string FirstNumber = "(000) 000-00-01";
            string Text = string.Empty;
            using (System.IO.StreamReader Reader = System.IO.File.OpenText(Path)) {
                Text = Reader.ReadToEnd();
            }

            if (Text.Contains(FirstNumber)) {
                string Pattern = @"\D(\S{4})\D\S*";
                string Result = "+000 00 000 00 01";
                Regex regex = new Regex(Pattern);
                string ResultOfConvert = regex.Replace(FirstNumber, Result);
                string Fin = Text.Replace(FirstNumber, ResultOfConvert);
                using (System.IO.StreamWriter File = new System.IO.StreamWriter(Path)) {
                    File.Write(Fin);
                }
            }

            Console.Clear();
            if (!Text.Contains(FirstNumber)) {
                Console.Write("Numbers not found");
            }
            else {
                Console.WriteLine("Numbers EDIT: successfully");
            }
            Console.ReadKey();
        }
    }
}