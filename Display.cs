using System;

namespace efdd
{
    public enum Color
    {
        /// <summary>
        ///     Черный цвет
        /// </summary>
        Black = 0,

        /// <summary>
        ///     Темно-синий цвет
        /// </summary>
        DarkBlue = 1,

        /// <summary>
        ///     Темно-зеленый цвет
        /// </summary>
        DarkGreen = 2,

        /// <summary>
        ///     Темный сине-зеленый цвет
        /// </summary>
        DarkCyan = 3,

        /// <summary>
        ///     Бордовый цвет
        /// </summary>
        DarkRed = 4,

        /// <summary>
        ///     Красно-коричневый цвет
        /// </summary>
        DarkMagenta = 5,

        /// <summary>
        ///     Темно-желтый цвет
        /// </summary>
        DarkYellow = 6,

        /// <summary>
        ///     Серый цвет
        /// </summary>
        Gray = 7,

        /// <summary>
        ///     Темно-серый цвет
        /// </summary>
        DarkGray = 8,

        /// <summary>
        ///     Синий цвет
        /// </summary>
        Blue = 9,

        /// <summary>
        ///     Зеленый цвет
        /// </summary>
        Green = 10,

        /// <summary>
        ///     Сине-зеленый цвет
        /// </summary>
        Cyan = 11,

        /// <summary>
        ///     Красный цвет
        /// </summary>
        Red = 12,

        /// <summary>
        ///     Фиолетовый цвет
        /// </summary>
        Magenta = 13,

        /// <summary>
        ///     Желтый цвет
        /// </summary>
        Yellow = 14,

        /// <summary>
        ///     Белый цвет
        /// </summary>
        White = 15
    }
    public struct Glyph
    {
        internal char Symbol;
        internal Color Ink;
        internal Color Paper;

        internal Glyph(char symbol, Color ink, Color paper)
        {
            Symbol = symbol;
            Ink = ink;
            Paper = paper;
        }
    }
    internal static class Display
    {
        internal static void Print(int x, int y, Char s, Color ink, Color paper)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }
    }
}