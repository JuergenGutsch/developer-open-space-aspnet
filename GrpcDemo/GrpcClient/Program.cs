
using Grpc.Net.Client;
using GrpcDemo;

// ACHTUNG: Die Demo benötigt den laufenden GrpcServer
var channel = GrpcChannel.ForAddress("http://localhost:5000");
var client = new Greeter.GreeterClient(channel);

var response = await client.SayHelloAsync(new HelloRequest { Name = args[0] });

// ACHTUNG: Diese Demo möchte ein argument. Also wie folgt aufrufen:
// > dotnet run World
Console.WriteLine($"{response.Message}!");
