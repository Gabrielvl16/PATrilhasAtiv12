using System;

class Program
{
    static void Main(string[] args)
    {
       int [] numeros = new int[10];
       float soma = 0, media = 0;
      
       foreach (int i in numeros)
       {
           Console.WriteLine("Digite um número:");
           numeros[i] = int.Parse(Console.ReadLine());
           soma += numeros[i];
           media = soma / 10;
       }
        Console.WriteLine("A media dos números é: " + media);
        
        Console.WriteLine("Pressione qualquer tecla para sair . . .");
        Console.ReadKey();
    }
}
