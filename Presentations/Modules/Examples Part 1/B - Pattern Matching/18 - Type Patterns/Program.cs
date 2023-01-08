using System;

namespace Wincubate.CS10.Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            object o1 = 87;
            object o2 = "Yeah!";

            var t = (o1, o2);

            if (t is (int _, string _))
            {
                Console.WriteLine("o1 is an int and o2 is a string");
            }
        }
    }
}
