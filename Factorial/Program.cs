// See https://aka.ms/new-console-template for more information

namespace Factorial
{
    class Program
    {
        static void Main(string[] )
        {
            int num = 6;
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
            Console.ReadLine();
        }
    }
}

