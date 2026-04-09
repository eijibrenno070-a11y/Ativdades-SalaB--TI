//Brenno Eiji da Silva Furuko

Console.OutputEncoding = System.Text.Encoding.UTF8;

float moeda, converorReal, resultado;
int escolha;
Console.WriteLine("Digite o valor em reais que deseja converter: ");
float.TryParse(Console.ReadLine(), out moeda);
Console.WriteLine("\nDigite 1 para converter para dólar\n" +
    "Digite 2 para converter para libras\nDigite: ");
int.TryParse(Console.ReadLine(), out escolha);
switch (escolha)
{
    case 1:
        Console.Write("Digite o valor do dólar turismo: ");
        float.TryParse(Console.ReadLine()!.Replace(".", ","), out converorReal);
        resultado = moeda * converorReal;
        Console.WriteLine($"R${moeda} x U${converorReal} = R${resultado}");
        break;

    case 2:
        Console.Write("Digite o valor da libras: ");
        float.TryParse(Console.ReadLine()!.Replace(".", ","), out converorReal);
        resultado = moeda * converorReal;
        Console.WriteLine($"R${moeda} x GBP{converorReal} = R${resultado}");
        break;

    default:
        Console.WriteLine("Digite um valor válido");
        break;



}
