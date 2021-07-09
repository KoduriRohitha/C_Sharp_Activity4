using System;

namespace Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;
            int y = 1;
            while (count < 9)
            {
                if (words[count].Contains(letter))
                {
                    Console.WriteLine(words[count]);
                    y += count;
                }
                count++;
            }
            if (y == 0 || y == 1)
            {
                Console.WriteLine("No match");
            }
        }
    }
}
