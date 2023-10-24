using System;

class Program
{
    static void Main(string[] args)
    {
        var concert = new Concert("Summer Fest", new Address { Street = "4820 Zone 9 Street", City = "George", State = "CAW", Country = "RSA" }, DateTime.Now.AddDays(30), "Parlotones");
        var party = new Party("Birthday Bash", new Address { Street = "456 Industrial Street", City = "Mossel Bay", State = "CBS", Country = "Ghana" }, DateTime.Now.AddDays(60), "John Dorris ");

        Console.WriteLine(concert.GetInviteMessage());
        Console.WriteLine(party.GetInviteMessage());
    }
}
