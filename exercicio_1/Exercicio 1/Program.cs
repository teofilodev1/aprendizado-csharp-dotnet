namespace exercicio_1;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite seu nome:");

        string nome = Console.ReadLine();
        int letras = nome.Length;

        Console.WriteLine($"\nOlá { nome }, seu nome tem { letras } caracterese no nome");
    }

}