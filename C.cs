using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[5];

        int maiorNumero = 0;
        foreach (int i in numeros)
        {
            Console.WriteLine("Digite um número: ");
            numeros[i] = int.Parse(Console.ReadLine());
            
            if (numeros[i] > maiorNumero)
            {
                maiorNumero = numeros[i];
            }
        }
        Console.WriteLine("O maior número é: " + maiorNumero);
        
        Console.WriteLine("Pressione qualquer tecla para sair . . .");
        Console.ReadKey();
    }
}
