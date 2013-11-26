using System;

// все библиотеки используешь;)


/* разделим задачу на подзадачи:
   1. Надо разделить строку на слова
 * 2. Поменять слова местами
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
            // теперь у нас в каждом элементе массива строк words лежит по слову. Проверим это выводом.
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            // тебе осталось поменять в массиве строк words все элементы местами
            for (int i = words.Length - 1; i < 0; i--)
            {
                Console.WriteLine(words[i]);
            }

            Console.ReadKey();
        }
    }
}