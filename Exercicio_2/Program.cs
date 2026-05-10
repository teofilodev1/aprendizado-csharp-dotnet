namespace Exercicio_2;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um numero:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite outro numero:");
        double b = Convert.ToDouble(Console.ReadLine());
        double result2 = a + b;

        if (result2 % 1 == 0)
        {
            Console.WriteLine("O resultado é inteiro: " + result2);
        }
        else
        {
            Console.WriteLine("O resultado é racional: " + result2);
        }
    }
}