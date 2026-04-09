Console.Write("Digite o número que você deseja ver a tabuada: ");

int numero = int.Parse(Console.ReadLine());

Console.WriteLine($"\nTabuada do {numero} (do 1 ao 100):");
Console.WriteLine("------------------------------");

for (int i = 1; i <= 100; i++)
{
    int resultado = numero * i;

    Console.WriteLine($"{numero} x {i} = {resultado}");
}

Console.WriteLine("------------------------------");
Console.WriteLine("Fim da tabuada. Aperte qualquer tecla para sair.");
