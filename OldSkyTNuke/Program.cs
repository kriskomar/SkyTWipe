using System;
using System.Threading;

namespace SkyTNuke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(
@"                     _______  .______        ______   .__   __.  _______ " + Environment.NewLine +
@"                    |       \ |   _  \      /  __  \  |  \ |  | |   ____|" + Environment.NewLine +
@"                    |  .--.  ||  |_)  |    |  |  |  | |   \|  | |  |__   " + Environment.NewLine +
@"                    |  |  |  ||      /     |  |  |  | |  . `  | |   __|  " + Environment.NewLine +
@"                    |  '--'  ||  |\  \----.|  `--'  | |  |\   | |  |____ " + Environment.NewLine +
@"                    |_______/ | _| `._____| \______/  |__| \__| |_______|" + Environment.NewLine +
@"                                                                            " + Environment.NewLine +
@"                                    DRONE FIRMWARE WIPE TOOL                " + Environment.NewLine +
@"                                                                            " + Environment.NewLine +
@"                       ***** WARNING: THIS TOOL DELETES EVERYTHING! *****   " + Environment.NewLine + Environment.NewLine + Environment.NewLine);
            Console.Write(@"       Begin data processing? (y/n) ");
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine();

            for (var i = 0; i < 1000; i++)
            {
                DrawProgressBar(i, 1000, 95, '#');
                Thread.Sleep(18);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write(@"       DELETE ALL DATA? (y/n) ");
            Console.ReadKey(true);
            Console.WriteLine();
            Console.Write(" C:\\> ");
            Console.ReadKey(true);
        }

        private static void DrawProgressBar(int complete, int maxVal, int barSize, char progressCharacter)
        {
            Console.CursorVisible = false;
            int left = Console.CursorLeft;
            decimal perc = (decimal)complete / (decimal)maxVal;
            int chars = (int)Math.Floor(perc / ((decimal)1 / (decimal)barSize));
            string p1 = String.Empty, p2 = String.Empty;

            for (int i = 0; i < chars; i++) p1 += progressCharacter;
            for (int i = 0; i < barSize - chars; i++) p2 += progressCharacter;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(p1);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(p2);

            Console.ResetColor();
            Console.Write(" {0}%", (perc * 100).ToString("N2"));
            Console.CursorLeft = left;
        }


    }
}