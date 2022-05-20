using System;


namespace ConsoleClicker
{
    class Clicker
    {
        //Properties
        public int Count { get; set; }
        public readonly ConsoleKey _key;
        //Constructer
        public Clicker(ConsoleKey key)
        {
            _key = key;
            Count = 0;
        }
        //Metheds
        public void Click(ConsoleKey key)
        {
            if(key == _key)
            {
                Count++;
            }
        }

        public void Show()
        {
            Console.WriteLine($"Press {_key} Poengsum: {Count}");
        }
    }
}
