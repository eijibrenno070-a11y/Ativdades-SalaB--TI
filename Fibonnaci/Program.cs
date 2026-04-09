//Brenno Eiji da Silva Furuko

Console.Write("Quantos números da sequência de Fibonacci você deseja ver? ");
int termos = int.Parse(Console.ReadLine());

int anterior = 0;
int atual = 1;

Console.WriteLine("\nSequência de Fibonacci:");
Console.Write($"{anterior}, {atual}");

for (int i = 3; i <= termos; i++)
{
    int proximo = anterior + atual;
    Console.Write($", {proximo}");

    anterior = atual;
    atual = proximo;
}

Console.WriteLine("\n\nFim da sequência. Aperte qualquer tecla para sair.");

