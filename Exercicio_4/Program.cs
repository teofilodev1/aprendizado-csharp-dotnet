using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Threading.Tasks.Sources;

namespace exercicio_4;
public class Program
{
    public static void Main()
    {
        int[] notas = { 4, 5, 4, 4, 1 };
        int soma = 0;
        foreach (int nota in notas)
        {
            soma += nota;
        }
        double media = (double)soma / notas.Length;
        if (media >= 6)
        {
            Console.WriteLine($"Aprovado média: {media}");
        }
        else if (media <= 4)
        {
            Console.WriteLine($"Reprovado média: {media}");
        }
        else
        {
            Console.WriteLine($"Recuperação média: {media}");
        }
    }
}