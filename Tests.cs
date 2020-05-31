using System;
using efdd.data;

namespace efdd
{
    public static class Tests
    {
        public static void TestColors()
        {
            // Get an array with the values of ConsoleColor enumeration members.
            var colors = (ConsoleColor[]) Enum.GetValues(typeof(ConsoleColor));
            // Save the current background and foreground colors.
            var ink = Console.BackgroundColor;
            var paper = Console.ForegroundColor;

            // Display all foreground colors except the one that matches the background.
            Console.WriteLine("All the foreground colors except {0}, the background color:",
                ink);
            foreach (var color in colors)
            {
                if (color == ink) continue;

                Console.ForegroundColor = color;
                Console.WriteLine("   The foreground color is {0}.", color);
            }

            Console.WriteLine();
            // Restore the foreground color.
            Console.ForegroundColor = paper;

            // Display each background color except the one that matches the current foreground color.
            Console.WriteLine("All the background colors except {0}, the foreground color:",
                paper);
            foreach (var color in colors)
            {
                if (color == paper) continue;

                Console.BackgroundColor = color;
                Console.WriteLine("   The background color is {0}.", color);
            }

            // Restore the original console colors.
            Console.ResetColor();
            Console.WriteLine("\nOriginal colors restored...");
        }

        public static void TestDatabase()
        {
            using var db = new Model();
            {
                db.Database.EnsureCreated();
                var items = db.Items;

                foreach (var item in items)
                    Console.WriteLine($"{item.Uid}\t" +
                                      $"{item.Symbol}\t" +
                                      $"{item.Ink}\t" +
                                      $"{item.Paper}\t" +
                                      $"{item.Name}");
            }
        }
    }
}