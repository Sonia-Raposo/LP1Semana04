using System;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        private static int GetSpecial(int n) 
        {

            int calc; 

            //exception for 0 
            if (n== 0)
            {
                calc = 0;
            } 

            //exception for 1
            else if (n == 1)
            {
                calc = 1;
            }

            //all other numbers
            else
            {         
                calc = GetSpecial(n-1) + 2 * GetSpecial(n-2);
            }
         
            return calc;
    }
}
