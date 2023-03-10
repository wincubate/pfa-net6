using System;

namespace Wincubate.CS10.Part2.Slide59
{
    class ConsoleLogger : ILogger
    {
        public void Log(LogLevel level, string message)
        {
            switch (level)
            {
                case LogLevel.Error:
                    WriteInColor(ConsoleColor.Yellow, message);
                    break;
                case LogLevel.Info:
                    WriteInColor(ConsoleColor.Green, message);
                    break;
                default:
                case LogLevel.Debug:
                    WriteInColor(ConsoleColor.Gray, message);
                    break;
            }
        }

        // Replace default interface implementation
        public void Log( Exception exception )
        {
            WriteInColor(ConsoleColor.Red, exception.ToString());
        }

        private void WriteInColor(ConsoleColor color, string line)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(line);
            Console.ResetColor();
        }
    }
}
