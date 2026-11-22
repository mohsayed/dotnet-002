
using ConsoleApp1;
using ConsoleApp1.utilities;

Console.WriteLine("Hello, World!");

 ArrayDemo.ArrayDemo03();

var connectionString =
    Environment.GetEnvironmentVariable("ConnectionStrings__Database");

Console.WriteLine(connectionString);

/*
var connectionString =
    Environment.GetEnvironmentVariable("ConnectionStrings__Database")
    ?? throw new InvalidOperationException(
        "ConnectionStrings__Database is not configured.");
*/


