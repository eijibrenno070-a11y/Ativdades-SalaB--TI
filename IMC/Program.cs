Console.WriteLine("--- CALCULADORA DE IMC ---");

Console.Write("Digite seu peso (kg): ");
double peso = double.Parse(Console.ReadLine());

Console.Write("Digite sua altura (ex: 1,75): ");
double altura = double.Parse(Console.ReadLine());

double imc = peso / (altura * altura);

Console.WriteLine($"\nSeu IMC é: {imc:F2}");

if (imc < 18.5)
{
    Console.WriteLine("Classificação: Abaixo do peso.");
    Console.WriteLine("Status: Não está no nível saudável.");
}
else if (imc >= 18.5 && imc <= 24.9)
{
    Console.WriteLine("Classificação: Peso normal.");
    Console.WriteLine("Status: Você está saudável.");
}
else if (imc >= 25 && imc <= 29.9)
{
    Console.WriteLine("Classificação: Sobrepeso.");
    Console.WriteLine("Status: Atenção, acima do nível saudável.");
}
else
{
    Console.WriteLine("Classificação: Obesidade.");
    Console.WriteLine("Status: Alerta, procure orientação médica.");
}

Console.WriteLine("\n--------------------------");
Console.WriteLine("Pressione qualquer tecla para sair.");
