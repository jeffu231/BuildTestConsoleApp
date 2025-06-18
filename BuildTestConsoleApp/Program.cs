// See https://aka.ms/new-console-template for more information

using System.Reflection;

Console.WriteLine("Hello, World");

Console.WriteLine("Hello, World fix");

// Add a new comment
// Another comment
// More stuff
Version version = Assembly.GetExecutingAssembly().GetName().Version ?? Version.Parse("0.0.0.0");
Console.WriteLine($"The version of the currently executing assembly is: {version}");