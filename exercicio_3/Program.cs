using System.Security.Cryptography.X509Certificates;

namespace Exercicio_3;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número:");
        int a = int.Parse(Console.ReadLine());
        int contador = 1;

        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine($"{a} x {i} = {a * i}");
        }

        Console.WriteLine("=====================");
        Console.WriteLine($"Tabuada do Numero: {a}");
        while (contador <= 10)
        {
            Console.WriteLine($"{a} x {contador} = {a * contador}");
            contador++;
        }
    }
}