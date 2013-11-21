using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;

namespace UnfoldingLines {
    class Program
    {
        static void Main() {
            Console.WriteLine("Enter the string...");
            string s = Console.ReadLine();
            string[] str = s.Split();
            string[] newstr = new string[str.Length];

            for (int i = 0; i < str.Length; i++) {
                newstr[i] = str[i];
            }

            Array.Reverse(newstr);
            Console.WriteLine("Inverted string: " + newstr);

            Console.ReadKey();
        }
    }
}
