using System;
using System.Collections.Generic;

namespace Week6
{
    class Program
    {
        static void Main(string[] args)
        {
            ProblemOne();
            ProblemTwo();
        }

        static void ProblemOne()
        {
            List<string> likes = new List<string>();
            string hold = "";

            do
            {
                Console.WriteLine("Enter a name to add to the like list: ");
                hold = Console.ReadLine();
                if (hold != "") { likes.Add(hold); }

            } while (hold != "");

            if (likes.Count > 2)
                Console.WriteLine(likes[0] + "," + likes[1] + " and " + (likes.Count - 2) + " others like your post");
            else if (likes.Count == 2)
                Console.WriteLine(likes[0] + " and " + likes[1] + " like your post");
            else if (likes.Count == 1)
                Console.WriteLine(likes[0] + " likes your post");
            else
                return ;
        }

        static void ProblemTwo()
        {
            Dictionary<char, int> charIntCount = new Dictionary<char, int>();
            string userSentence = "";

            Console.WriteLine("Enter a sentence!");
            userSentence = Console.ReadLine();

            foreach (char i in userSentence) {
                try
                {
                    charIntCount.Add(i, 1);
                }
                catch (ArgumentException)
                {
                    charIntCount[i] += 1;
                }
            }

            foreach (KeyValuePair<char, int> i2 in charIntCount)
            {
                Console.WriteLine(i2.Key + "|" + i2.Value);
            }

        }
    }
}
