using System;

namespace OOP_lab_3_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; ++i)
            {
                for (int j = 0; j < words[i].Length; ++j)
                {
                    if (((words[i][j] >= (char)65) && (words[i][j] <= (char)90)) || ((words[i][j] >= (char)97) && (words[i][j] <= (char)122)))
                    {
                        words[i] = words[i].Remove(0);
                        break;
                    }
                }
            }

            for (int i = 0; i < words.Length; ++i)
            {
                if (!String.IsNullOrWhiteSpace(words[i]))
                {
                    int k = words[i].Length;

                    for (int j = 0; j < words[i].Length; ++j)
                    {
                        if ((words[i][j] >= (char)48) && (words[i][j] <= (char)57))
                        {
                            --k;
                        }
                    }

                    if (k == 0)
                    {
                        words[i] = words[i].Remove(0);
                    }
                }
            }

            Console.WriteLine();

            foreach (string word in words)
            {
                if (!String.IsNullOrWhiteSpace(word))
                {
                    Console.WriteLine("{0} ", word);
                }
            }
        }
    }
}
