using System;

// все библиотеки используешь;)


/* разделим задачу на подзадачи:
   1. Надо разделить строку на слова
   2. Поменять слова местами
 */

namespace UnfoldingLines {
    class Program
    {
        static void Main() {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();

            /* разделение строки на слова. Слова разделяются друг с другом пробелами и всякими разделителями, типа точек, запятых и т.д. 
             * Мы возьмём простой вариант и примем, что иных разделителей, кроме как пробелы между словами у нас нет.
            */
            string[] words = s.Split(' ');
            string[] a = new string[words.Length];
            string b;
            // теперь у нас в каждом элементе массива строк words лежит по слову. Проверим это выводом.
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
                a[i] = words[i];
            }
            // тебе осталось поменять в массиве строк words все элементы местами
            //for (int i = words.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(words[i] + " ");
            //}
            int n = a.Length;
            for (int i = 0; i < n / 2 ; i++)
            {
                b = a[i];
                a[i] = a[n - i - 1];
                a[n - i - 1] = b;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            //for (int i = 0; i < words.Length - 1; i++)
            //{
            //    Console.Write(b);
            //}
			// ок. это вывела их задом наперёд. А теперь твоя задача именно поменять местами элементы в массиве. Не просто вывод, сами внутри массива поменять местами.
            Console.ReadKey();
        }
    }
}