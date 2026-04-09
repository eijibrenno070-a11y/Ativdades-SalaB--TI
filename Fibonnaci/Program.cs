// 1. Pergunta quantos números o usuário quer ver
Console.Write("Quantos números da sequência de Fibonacci você deseja ver? ");
int termos = int.Parse(Console.ReadLine());

// 2. Definimos os dois primeiros números da sequência
int anterior = 0;
int atual = 1;

Console.WriteLine("\nSequência de Fibonacci:");
Console.Write($"{anterior}, {atual}"); // Já mostra os dois primeiros

// 3. O laço começa do 3, pois já mostramos os 2 primeiros números acima
for (int i = 3; i <= termos; i++)
{
    int proximo = anterior + atual; // Soma os dois anteriores
    Console.Write($", {proximo}");

    // 4. "Anda" com os valores para a próxima rodada
    anterior = atual;
    atual = proximo;
}

Console.WriteLine("\n\nFim da sequência. Aperte qualquer tecla para sair.");
Console.ReadKey();
