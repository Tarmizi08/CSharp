using System;

namespace Enums
{
    //enum Level
    //{
    //    Low,
    //    Medium, 
    //    High
    //}

    class Program
    {
        enum Level
        {
            Low = 1, Medium, High
        }
        static void Main(string[] args)
        {
            Level myLevel = Level.Low;
            Console.WriteLine(myLevel);

            int myLevel2 = (int)Level.Medium;
            Console.WriteLine(myLevel2);

            Level level = Level.Low;

            switch (level)
            {
                case Level.Low:
                    Console.WriteLine("Level is low");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium Level");
                    break;
                case Level.High:
                    Console.WriteLine("High Level");
                    break;
                default:
                    Console.WriteLine("What is your level");
                    break;
            }
            ;
        }
    }
}

