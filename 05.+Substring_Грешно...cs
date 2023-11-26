namespace Debugging_Substring
{
    using System;

    public class Substring_broken
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'р';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;

                    int endIndex = jump;

                    if (endIndex > text.Length)
                    {
                        endIndex = text.Length;
                    }

                    string matchedString = text.Substring(i, endIndex+1);
                    Console.WriteLine(matchedString);
                    i = endIndex+1;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
