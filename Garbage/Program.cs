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
        Deck deck = new Deck();
        Hand hand = new Hand(deck);
        hand.displayHand();
        Console.WriteLine(deck.peekTopCard().toSymbol());
        }
    }
}
