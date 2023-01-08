class Program
{
    static void Main(string[] args)
    {
        Money m = new(87, 25);
        //m.Euro = 176;
    }
}

record Money(int Euro, int Cents)
{
    public int TotalCents => Euro * 100 + Cents;
}
