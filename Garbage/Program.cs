// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

// app.Run();



using System;

namespace Garbage
{
    class Program
    {
        static void Main(string[] args)
        {
        Card myVar = new Card(Rank.ACE, Suit.SPADES);
        Console.WriteLine(myVar.toString());
        }
    }
}
