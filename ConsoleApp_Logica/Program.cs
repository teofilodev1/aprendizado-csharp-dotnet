using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Treino de Lógica - Desafio 1: Par ou Ímpar");
        Console.Write("Digite um número inteiro: ");

        var input = Console.ReadLine();
        if (!int.TryParse(input, out int n))
        {
            Console.WriteLine("Entrada inválida.");
            return;
        }

        if (n % 2 == 0)
            Console.WriteLine($"{n} é PAR");
        else
            Console.WriteLine($"{n} é ÍMPAR");
    }
}

