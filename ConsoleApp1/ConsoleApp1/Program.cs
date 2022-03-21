using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Add();
            //Try();
            addi();

        }
        static void Add()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("{0} is great", a);
            Console.WriteLine($"Hello i am good boy {b} is great\t as i am alone\n and genuine guy\r as");
        }
        static void Try()
        {
            int k = 20;
            Console.WriteLine((k > 3000) ? "good" : "bad");
        }
        static void addi()
        {
            int x = 50;
                int y = 100;
            Console.WriteLine("add" + x + y);
            }
    }
}

