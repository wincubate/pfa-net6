class Program
{
    static void Main(string[] args)
    {
        Money m1 = new(87, 25);
        Money m2 = new(87, 25);

        Console.WriteLine(m1 == m2);
    }
}

record Money( int Euro, int Cents)
{
}
