Console.WriteLine("--- VERIFICADOR DE NÚMEROS PRIMOS ---");


Console.Write("Digite um número inteiro positivo: ");
int numero = int.Parse(Console.ReadLine());

int divisores = 0;

if (numero <= 1)
{
    Console.WriteLine($"{numero} não é um número primo.");
}
else
{ 
    for (int i = 1; i <= numero; i++)
    {
        if (numero % i == 0)
        {
            divisores++;
        }
    }

    if (divisores == 2)
    {
        Console.WriteLine($"O número {numero} é PRIMO.");
    }
    else
    {
        Console.WriteLine($"O número {numero} NÃO É PRIMO (ele possui {divisores} divisores).");
    }
}

Console.WriteLine("\nFim da verificação.");

