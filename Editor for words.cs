using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using System.Collections;

namespace Lab_5 {
    internal class ChangingWords {
        public static void SearchingWrongWords(string Path) {
            var Words = new List<string>()
            {
               "helo", "halo", "heelo", "wellcame", "welkom", "willkomm"
            };
            var UsingWords = new List<string>(Words);

            for (int IndexOfWord = 0; IndexOfWord < UsingWords.Count; ++IndexOfWord) {
                if (UsingWords [IndexOfWord] == "helo" || UsingWords [IndexOfWord] == "halo" || UsingWords [IndexOfWord] == "heelo") {
                    string Word = UsingWords [IndexOfWord];
                    string Text = string.Empty;
                    using (System.IO.StreamReader Reader = System.IO.File.OpenText(Path)) {
                        Text = Reader.ReadToEnd();
                    }
                    if (Text.Contains(Word)) {
                        string RightWord = "hello";
                        string Result = Text.Replace(Word, RightWord);
                        using (System.IO.StreamWriter File = new System.IO.StreamWriter(Path)) {
                            File.Write(Result);
                        }
                    }
                }
                else if (UsingWords [IndexOfWord] == "wellcame" || UsingWords [IndexOfWord] == "welkom" || UsingWords [IndexOfWord] == "willkomm") {
                    string Word = UsingWords [IndexOfWord];
                    string Text = string.Empty;
                    using (System.IO.StreamReader Reader = System.IO.File.OpenText(Path)) {
                        Text = Reader.ReadToEnd();
                    }
                    if (Text.Contains(Word)) {
                        string RightWord = "wellcome";
                        string Result = Text.Replace(Word, RightWord);
                        using (System.IO.StreamWriter File = new System.IO.StreamWriter(Path)) {
                            File.Write(Result);
                        }
                    }
                }
            }
            Console.Clear();
            Console.Write("Words EDIT: successfully");
            Console.ReadKey();
        }
    }
}