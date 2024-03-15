using System;
using System.Net;
using System.Xml.XPath;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
    }
}
