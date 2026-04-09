Console.WriteLine("--- CALCULADOR DE RAIZ QUADRADA ---");

Console.Write("Digite um número: ");
double numero = double.Parse(Console.ReadLine());

if (numero < 0)
{
    Console.WriteLine("Erro: Não é possível calcular a raiz quadrada de um número negativo no conjunto dos Reais.");
}
else
{
    double raiz = Math.Sqrt(numero);
    
    if (raiz == (int)raiz)
    {
        Console.WriteLine($"\nA raiz quadrada de {numero} é {raiz}.");
        Console.WriteLine("Esta é uma RAIZ EXATA.");
    }
    else
    {
        
        Console.WriteLine($"\nA raiz quadrada de {numero} é aproximadamente {raiz:F4}.");
        Console.WriteLine("Esta NÃO É uma raiz exata.");
    }
}

Console.WriteLine("\nFim do programa. Pressione qualquer tecla para sair.");

