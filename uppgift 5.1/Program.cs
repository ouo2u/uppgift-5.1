using System;

namespace uppgift5_1
{
    class program
    {
        static void Main(string[] args)
        {
            string[] text = new string[4];
            text[0] = "yep";
            text[1] = "yes";
            text[2] = "yee";
            text[3] = "yeee";

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(text[i]);
                Console.WriteLine("");
            }
        }
    }
}