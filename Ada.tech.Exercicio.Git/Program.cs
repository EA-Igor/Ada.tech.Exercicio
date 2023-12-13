// See https://aka.ms/new-console-template for more information
using Ada.tech.Exercicio.Git;

Console.WriteLine("Hello, World!");

decimal x, y, resultado;
int escolha;

Console.WriteLine("Bem-vindo a calculadora! ");
Console.WriteLine("Escolha a operação desejada: ");
Console.WriteLine("Digite 1 para Subtração");
Console.WriteLine("Digite 2 para Adicão");
Console.WriteLine("Digite 3 para Divisão");
Console.WriteLine("Digite 4 para Multiplicação");
int.TryParse(Console.ReadLine(), out escolha);

Console.WriteLine("Insira os números para realizar as operações: ");
decimal.TryParse(Console.ReadLine(), out x);
decimal.TryParse(Console.ReadLine(), out y);

switch (escolha)
{
    case 1:
        Subtracao sub1 = new Subtracao();
        resultado = sub1.EfetuarSubtracao(x, y);
        Console.WriteLine($"O resultado é: {resultado} ");
        break;
    case 2:
        Adicao add1 = new Adicao();
        resultado = add1.EfetutuarAdicao(x, y);
        Console.WriteLine($"O resultado é: {resultado} ");
        break;
    case 3:
        Divisao div1 = new Divisao();
        resultado = div1.efetuarDivisao(x, y);
        Console.WriteLine($"O resultado é: {resultado} ");
        break;
    case 4:
        Multiplicacao mul1 = new Multiplicacao();
        resultado = mul1.efetuarMultiplicacao(x,y);
        Console.WriteLine($"O resultado é: {resultado} ");
        break;
}