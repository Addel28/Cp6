using System;

namespace ConsoleApp1
{

    class Program
    {
        enum WeekDays
        {
            Tuesday,
            Monday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public enum Color
        {
            Red,
            Green,
            Blue,
            Yellow,
            Cyan,
            Magenta
        }
        enum Opers
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }
        public static string GetHexCode(Color color)
        {
            string HexColor = string.Empty;
            switch (color)
            {
                case Color.Red: HexColor = "FF0000"; break;
                case Color.Green: HexColor = "00FF00"; break;
                case Color.Blue: HexColor = "0000FF"; break;
                case Color.Yellow: HexColor = "FFFF00"; break;
                case Color.Cyan: HexColor = "00FFFF"; break;
                case Color.Magenta: HexColor = "FF00FF"; break;
            }
            return HexColor;
        }
        static void Main()
        {
            foreach (var day in Enum.GetValues(typeof(WeekDays)))
            {
                WeekDays days = (WeekDays)day;
                Console.Write($"{days} - ");

                switch (days)
                {
                    case WeekDays.Monday:
                        Console.WriteLine("Понедельник");
                        break;
                    case WeekDays.Tuesday:
                        Console.WriteLine("Вторник");
                        break;
                    case WeekDays.Wednesday:
                        Console.WriteLine("Среда");
                        break;
                    case WeekDays.Thursday:
                        Console.WriteLine("Четверг");
                        break;
                    case WeekDays.Friday:
                        Console.WriteLine("Пятница");
                        break;
                    case WeekDays.Saturday:
                        Console.WriteLine("Cуббота");
                        break;
                    default:
                        Console.WriteLine("Воскресенье");
                        break;
                }
            }
            Console.WriteLine("-------------------");
            foreach (var colorr in Enum.GetValues(typeof(Color)))
            {
                Color colorrr = (Color)colorr;
                Console.Write($"{colorrr} - ");

                switch (colorrr)
                {
                    case Color.Red:
                        Console.WriteLine("FF0000");
                        break;
                    case Color.Green:
                        Console.WriteLine("00FF00");
                        break;
                    case Color.Blue:
                        Console.WriteLine("0000FF");
                        break;
                    case Color.Yellow:
                        Console.WriteLine("FFFF00");
                        break;
                    case Color.Cyan:
                        Console.WriteLine("00FFFF");
                        break;
                    case Color.Magenta:
                        Console.WriteLine("FF00FF");
                        break;
                    default:
                        Console.WriteLine("Другой цвет");
                        break;
                }
            }
            Console.WriteLine("-------------------");
            int a = 100;
            int b = 50;
            Opers op = Opers.Subtract;

            Console.WriteLine($"{a} и {b} при операции {Opers.Multiply}: {UseOp(a, b, op)}");
        }
        static int UseOp(int a, int b, Opers op)
        {
            switch (op)
            {
                case Opers.Add:
                    return a + b;
                case Opers.Subtract:
                    return a - b;
                case Opers.Multiply:
                    return a * b;
                default:
                case Opers.Divide:
                    return a / b;
            }
        }
    }
}