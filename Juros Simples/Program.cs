Console.WriteLine("--- CÁLCULO DE JUROS SIMPLES ---");

Console.Write("Digite o Capital (C): ");
double capital = double.Parse(Console.ReadLine());

Console.Write("Digite a Taxa de Juros mensal (i) em %: ");
double taxaPorcentagem = double.Parse(Console.ReadLine());

Console.Write("Digite o Tempo (t) em meses: ");
int tempo = int.Parse(Console.ReadLine());

double taxaDecimal = taxaPorcentagem / 100;

double juros = capital * taxaDecimal * tempo;

double montante = capital + juros;

Console.WriteLine("\n--- RESULTADOS ---");
Console.WriteLine($"Total de Juros: {juros}");
Console.WriteLine($"Montante Final: {montante}");

Console.WriteLine("\nCálculo finalizado.");
