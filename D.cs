using System;

class Program
{
    static void Main(string[] args)
    {
        string [] palavras = new string[5];
        string maiorPalavra = " ";

        for (int i = 0; i < palavras.Length; i++)
        {
            Console.WriteLine("Digite uma palavra: ");
            palavras[i] = Console.ReadLine();
        }
        
        foreach (string palavra in palavras)
        {
           if (palavras.Length > maiorPalavra.Length)
           {
               maiorPalavra = palavra;
           }
        }
        Console.WriteLine("A maior palavra é: " + maiorPalavra);
        
        Console.WriteLine("Pressione qualquer tecla para sair . . .");
        Console.ReadKey();
    }
}
