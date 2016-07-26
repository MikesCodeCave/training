using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoApp
{
    class Helper
    {
        static string[] messages = { "Hello World!", "How are you feeling?", "Its a nice day.", "Cats are cool", "Dogs not so much." };
        static Random r = new Random();

        public static void ShowMessages()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(GetRandomMessage());
                Thread.Sleep(500);
            }
        }

        private static string GetRandomMessage()
        {
            int idx = r.Next(0, 5);
            return messages[idx];
        }
    }
}
