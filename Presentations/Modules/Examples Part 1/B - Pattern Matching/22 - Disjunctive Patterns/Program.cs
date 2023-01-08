using System;
using System.Collections.Generic;

namespace Wincubate.CS10.Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<object> elements = new List<object>
            {
                42, "Yay", 87.0, "Nay", 12.7m
            };

            foreach (var o in elements)
            {
                Console.WriteLine(o switch
                {
                    int or double or decimal => $"{o} is a number",
                    _ => "Not a number..."
                });
            }
        }
    }
}