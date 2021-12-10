var builder = WebApplication.CreateBuilder();




var app = builder.Build();



app.MapGet("/", () => "Hallo DOS!");



app.Run();




//Console.WriteLine($"Hallo {args[0]} !");