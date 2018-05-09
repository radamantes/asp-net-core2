using System;

namespace fibonnaci
{
    public class Program
    {

        

        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 1;

            for (int i = 0; i < 10; i++)
            {
                a = b + c;
                b = c;
                c = a;

                Console.WriteLine(b);
               
            }
        }
    }
}
