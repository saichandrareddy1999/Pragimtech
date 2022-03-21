using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Switch();
            For_Loop();
        }
        static void Switch()
        {
            Char c;
            Console.Write("Enter a character: ");
            c = Convert.ToChar(Console.ReadLine());
            switch (c)
            {
                case 'a':
                    Console.WriteLine("Vowel!");
                    break;
                case 'e':
                    Console.WriteLine("Vowel!");
                    break;
                case 'i':
                    Console.WriteLine("Vowel!");
                    break;
                case 'o':
                    Console.WriteLine("Vowel!");
                    break;
                case 'u':
                    Console.WriteLine("Vowel!");
                    break;
                case 'A':
                    Console.WriteLine("Vowel!");
                    break;
                case 'E':
                    Console.WriteLine("Vowel!");
                    break;
                case 'I':
                    Console.WriteLine("Vowel!");
                    break;
                case 'O':
                    Console.WriteLine("Vowel!");
                    break;
                case 'U':
                    Console.WriteLine("Vowel!");
                    break;
                default:
                    Console.WriteLine("Consonant");
                    break;

            }
        }
        static void For_Loop()
        {
            /*for(int i=0;i<=5;i++)
             {
                 Console.WriteLine("Hello");
             }*/
            //for(int i=1;i<=20;i+=2)
            // {
            //     Console.WriteLine(i);
            // }
            // for (int k = 50; k >= 1; k--)
            // {
            //     Console.WriteLine(k);
            // }
            //for (int i = 1; i <= 10; i++)
            //{
            //    //Console.WriteLine("7 * " + i + " = " + (7 * i));
            //    Console.WriteLine("{0}*{1}={2}",7,i,(7*i));
            //}

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(6 - i);
            }
                
               

            






        }
    }
}

