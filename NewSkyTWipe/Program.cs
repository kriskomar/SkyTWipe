using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewSkyTWipe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"                          _____  _____   ____  _   _ ______  __          _______ _____  ______ ");
            Console.WriteLine(@"                         |  __ \|  __ \ / __ \| \ | |  ____| \ \        / /_   _|  __ \|  ____|");
            Console.WriteLine(@"                         | |  | | |__) | |  | |  \| | |__     \ \  /\  / /  | | | |__) | |__   ");
            Console.WriteLine(@"                         | |  | |  _  /| |  | | . ` |  __|     \ \/  \/ /   | | |  ___/|  __|  ");
            Console.WriteLine(@"                         | |__| | | \ \| |__| | |\  | |____     \  /\  /   _| |_| |    | |____ ");
            Console.WriteLine(@"                         |_____/|_|  \_\\____/|_| \_|______|     \/  \/   |_____|_|    |______|"); Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("                                        Press any key to begin gathering data...");
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine();

            using (var progress = new ProgressBar())
            {
                for (int i = 0; i <= 100; i++)
                {
                    progress.Report((double)i / 100);
                    Thread.Sleep(80);
                }
            }

            Console.WriteLine();
            Console.Write("                                       Data gathered. Commense with memory wipe?");
            Console.ReadKey();
            Console.WriteLine();

        }
    }
}
