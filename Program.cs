using System;
using System.Timers;
using System.Transactions;

namespace efdd
{
    internal static class Program
    {
        public static void Main()
        {
            const int consoleWidth = 200;
            const int consoleHeight = 60;
            var rand = new Random();

            SetConsoleTitle("Dwarf Defense");
            InitConsole(consoleWidth, consoleHeight);

            //TODO This is using just to check colors
            //TestColors();

            var timer = new Timer(50);
            
            timer.Elapsed += Timer_elapsed;
            timer.AutoReset = true;
            timer.Start();
            Console.Write("Timer started");
            

            Console.ReadKey();
            //TODO This is using just to check database access
            //TestDatabase();
        }

        internal static void Test(int w, int h)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(w, h);
            Console.Write('▒');
        }

        internal static void Timer_elapsed(object sender, ElapsedEventArgs e)
        {
            var rnd = new Random();
            int w = rnd.Next(0, 200);
            int h = rnd.Next(0, 60);
            Test(w, h);
        }

        private static void SetConsoleTitle(string title)
        {
            Console.Title = title;
        }

        private static void InitConsole(int consoleWidth, int consoleHeight)
        {
            Console.SetWindowSize(consoleWidth, consoleHeight);
            Console.SetBufferSize(consoleWidth, consoleHeight);
            Console.CursorVisible = false;
        }
    }
}