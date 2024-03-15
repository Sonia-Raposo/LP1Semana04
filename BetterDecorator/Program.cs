using System;
using System.Net;
using System.Xml.XPath;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length >= 3)
            {
                string s = args[0];

                char c =  char.Parse(args[1]);

                int i = int.Parse(args[2]);

                string result = Decor(s, c, i);

                Console.WriteLine(result);

            }

            //calls Decor with no arguments
            else
            {
                Console.WriteLine(Decor());  
            }
        }

        private static string Decor(string s, char decor, int i)
        {
            
            string result = "";

            // adding on left side
            for (int a = 0; a < i; a++)
            {
                result += decor;
            }

            result += " " + s + " ";

            // adding on right side
            for (int b = 0; b < i; b++)
            {
                result += decor;
            }

            return result;
        }

        private static string Decor()
        {
            return Decor("User did not specify args!", '=',3);

        }
    }
}
