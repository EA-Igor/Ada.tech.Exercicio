// See https://aka.ms/new-console-template for more information
using Ada.tech.Exercicio.Git;

Console.WriteLine("Hello, World!");

decimal x, y;
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
        sub1.EfetuarSubtracao(x, y);
        break;
    case 2:
        Adicao add1 = new Adicao();
        add1.EfetutuarAdicao(x, y);
        break;
    case 3:
        Divisao div1 = new Divisao();
        div1.efetuarDivisao(x, y);
        break;
    case 4:
        Multiplicacao mul1 = new Multiplicacao();
        break;