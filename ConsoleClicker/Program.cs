using System;

namespace ConsoleClicker
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Clicker(ConsoleKey.Q);
            Console.WriteLine("Press Q to play");
            game.Show();
            while (true)
            {
                var input = Console.ReadKey();
                game.Click(input.Key);
                Console.Clear();
                game.Show();
            }
        }
    }
}
