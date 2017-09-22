using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationGame
{
    class Program
    {
        private static void RenderText(string text)
        {
            char[] characters = text.ToCharArray();

            foreach (var character in characters)
            {
                Console.Write(character);

                if (character == ',')
                    System.Threading.Thread.Sleep(200);
                else
                    System.Threading.Thread.Sleep(100);
            }

            Console.WriteLine();
        }

        private static void Welcome()
        {
            string welcomeText = "Hello, what is your name?";
            RenderText(welcomeText);
        }

        private static void SayHello()
        {
            string name = Console.ReadLine();
            string helloText = string.Format("Hello {0}, I am computer!", name);
            RenderText(helloText);
        }

        static void Main(string[] args)
        {
            Welcome();
            SayHello();
            Console.Read();
            return;
        }
    }
}
