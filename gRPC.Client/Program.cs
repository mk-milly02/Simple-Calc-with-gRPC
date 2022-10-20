// See https://aka.ms/new-console-template for more information
using gRPC.Server;
using Grpc.Net.Client;

var channel = GrpcChannel.ForAddress("https://localhost:7180");
var client = new Calculator.CalculatorClient(channel);

Console.WriteLine("Welcome to Simple Calc");

CalculatorRequest request = new();

Console.Write("\nInput the first number: ");
request.X = Console.ReadLine();

Console.Write("\nInput the second number: ");
request.Y = Console.ReadLine();

var sum = client.Add(request);
var difference = client.Subtract(request);
var product = client.Multiply(request);
var quotient = client.Divide(request);

Console.WriteLine("\n");

Console.WriteLine($"Sum: {sum.Result}");
Console.WriteLine($"Difference: {difference.Result}");
Console.WriteLine($"Product: {product.Result}");
Console.WriteLine($"Quotient: {quotient.Result}");

Console.ReadKey();

