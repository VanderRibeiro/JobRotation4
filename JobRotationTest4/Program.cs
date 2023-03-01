using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Escreva uma palavra para ser invertida: ");
        string palavra = Console.ReadLine();

        char[] ctr = palavra.ToCharArray();
        Array.Reverse(ctr);
        palavra = new string(ctr);
        Console.WriteLine(palavra);
    }
}