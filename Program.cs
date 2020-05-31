using System;
using System.Timers;

namespace efdd
{
    internal static class Program
    {
        public static void Main()
        {
            const int consoleWidth = 200;
            const int consoleHeight = 60;

            var ink = Color.Black;
            var paper = Color.Yellow;

            SetConsoleTitle("Dwarf Defense");
            InitConsole(consoleWidth, consoleHeight);

            //TODO This is using just to check colors
            //TestColors();

            var timer = new Timer(500);
            timer.Elapsed += Timer_elapsed;
            timer.Start();


            //TODO This is using just to check database access
            //TestDatabase();
        }

        private static void Timer_elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(20, 20);
            Console.Write('a');
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