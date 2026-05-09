namespace exercicio_1;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        int character = nome.Length;

        Console.WriteLine($"Olá {nome},seja bem vindo, seu nome tem {character} caracteres");
    }
}