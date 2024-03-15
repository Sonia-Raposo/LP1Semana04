using System;
using System.Net;
using System.Xml.XPath;

namespace BetterDecorator
{
    
    /// <summary>
    /// Program receives 3 args and converts to string, char and int
    /// </summary>
    class Program
    {
        /// <summary>
        /// Checks if 3 arguments have been inserted
        /// If yes, calls Decor with 3 params
        /// If no, calls Decor with no params
        /// </summary>
        /// <param name="args"></param>
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

        /// <summary>
        /// Decor method that accepts 3 args (string, char and int)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="decor"></param>
        /// <param name="i"></param>
        /// <returns></returns>
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
