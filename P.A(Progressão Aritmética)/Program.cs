Console.OutputEncoding = System.Text.Encoding.UTF8;

int razão, termos, resultado = 0;
Console.Write("Digite o nº de Termos: ");
int.TryParse(Console.ReadLine()!, out termos);
Console.Write("Digite o nº da razão: ");
int.TryParse(Console.ReadLine()!, out razão);
for (int i = 1; i <= termos; i++)
{
    resultado =  resultado + razão;
    Console.Write($"{resultado}➡️");
}
Console.Write("Esses são os números");
