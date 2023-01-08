using System;

namespace Wincubate.CS10.Part2.Slide59
{
    enum LogLevel
    {
        Error,
        Info,
        Debug
    }

    interface ILogger
    {
        void Log(LogLevel level, string message);
        void Log(Exception exception) => Log(LogLevel.Error, exception.ToString());
    }
}
