// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

decimal x, y;

Console.WriteLine("Bem-vindo a calculadora! ");
Console.WriteLine("Insira os números para realizar as operações: ");
decimal.TryParse(Console.ReadLine(), out x);
decimal.TryParse(Console.ReadLine(), out y);