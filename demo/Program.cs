using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.Write("Enter number:");
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
            //hello world
            Console.Write("Enter ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello World!" + " " +id+" " + name);

        }

    }
}
