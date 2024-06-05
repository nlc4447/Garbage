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
        Deck myVar = new Deck();
        Console.WriteLine(myVar.peekTopCard().toSymbol());

        }
    }
}
