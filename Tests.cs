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
            var ink = Terminal.BackgroundColor;
            var paper = Terminal.ForegroundColor;

            // Display all foreground colors except the one that matches the background.
            Terminal.WriteLine("All the foreground colors except {0}, the background color:",
                ink);
            foreach (var color in colors)
            {
                if (color == ink) continue;

                Terminal.ForegroundColor = color;
                Terminal.WriteLine("   The foreground color is {0}.", color);
            }

            Terminal.WriteLine();
            // Restore the foreground color.
            Terminal.ForegroundColor = paper;

            // Display each background color except the one that matches the current foreground color.
            Terminal.WriteLine("All the background colors except {0}, the foreground color:",
                paper);
            foreach (var color in colors)
            {
                if (color == paper) continue;

                Terminal.BackgroundColor = color;
                Terminal.WriteLine("   The background color is {0}.", color);
            }

            // Restore the original console colors.
            Terminal.ResetColor();
            Terminal.WriteLine("\nOriginal colors restored...");
        }

        public static void TestDatabase()
        {
            using var db = new Model();
            {
                db.Database.EnsureCreated();
                var items = db.Items;

                foreach (var item in items)
                    Terminal.WriteLine($"{item.Uid}\t" +
                                      $"{item.Symbol}\t" +
                                      $"{item.Ink}\t" +
                                      $"{item.Paper}\t" +
                                      $"{item.Name}");
            }
        }
    }
}