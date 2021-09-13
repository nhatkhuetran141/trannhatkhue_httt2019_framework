using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number is: " + n);
            if (n == 1)
            {
                basic();
            }
            else if (n == 2)
            {
                Console.WriteLine("hi");
            }
        }
        static void basic()
        {
            Console.WriteLine("Hello World!");
        }

    }
}
