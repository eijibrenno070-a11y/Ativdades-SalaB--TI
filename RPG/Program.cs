//Brenno EIji da Silva Furuko﻿
// --- PARTE 1: O DESPERTAR ---
Console.WriteLine("Digite o nome do Herói");
string nomeHeroi = Console.ReadLine();
        char rank = 'S'; // Usando o tipo Char para o Rank

        Console.WriteLine($"--- A JORNADA DE {nomeHeroi} (Rank {rank}) ---");
        Console.WriteLine("O herói acorda em uma masmorra feita de códigos e chaves...\n");

        // --- PARTE 2: PREPARANDO AS ARMAS (SOMA) ---
        int ataqueBase = 45;
        int bonusEspadaExcaliburDotNet = 55;
        int ataqueTotal = ataqueBase + bonusEspadaExcaliburDotNet;

        Console.WriteLine($"[SOMA]: {nomeHeroi} equipa a lendária espada!!");
        Console.WriteLine($"Seu ataque base era {ataqueBase}, mas com o bônus de {bonusEspadaExcaliburDotNet},");
        Console.WriteLine($"o Poder Total de Ataque agora é: {ataqueTotal}.\n");

        // --- PARTE 3: O EMBATE COM O DRAGÃO (SUBTRAÇÃO) ---
        double vidaDragaoDeDados = 250.80;
        double danoDoGolpe = 120.30;
        double vidaRestanteInimigo = vidaDragaoDeDados - danoDoGolpe;

        Console.WriteLine($"[SUBTRAÇÃO]: Um Dragão de Dados surge com {vidaDragaoDeDados} de HP!");
        Console.WriteLine($"{nomeHeroi} desfere um golpe crítico de {danoDoGolpe} de dano.");
        Console.WriteLine($"O Dragão ruge de dor! Vida restante do monstro: {vidaRestanteInimigo}.\n");

        // --- PARTE 4: O TESOURO DOBRADO (MULTIPLICAÇÃO) ---
        float bauDePrata = 400.50f;
        var multiplicadorMagico = 2; // O var entende que isso é um int
        var tesouroFinal = bauDePrata * multiplicadorMagico; // O var entende que o resultado é float

        Console.WriteLine($"[MULTIPLICAÇÃO]: Ao derrotar o monstro, um baú com {bauDePrata} moedas é aberto.");
        Console.WriteLine($"Um feitiço de bônus multiplica o ouro por {multiplicadorMagico}!");
        Console.WriteLine($"O herói agora carrega {tesouroFinal} moedas de ouro purinho!\n");

        // --- PARTE 5: A SABEDORIA ANCESTRAL (DIVISÃO) ---
        long xpAntigo = 8000000000; // 8 Bilhões de XP
        long xpDivididoPeloMestre = xpAntigo / 2;

        Console.WriteLine($"[DIVISÃO]: O herói toca em um cristal de memória com {xpAntigo} de XP.");
        Console.WriteLine($"O conhecimento é demais para um homem só e se divide ao meio em sua mente.");
        Console.WriteLine($"Ele absorve uma média de {xpDivididoPeloMestre} de sabedoria por neurônio.\n");

        // --- PARTE 6: O VEREDITO ---
        bool entendiMateria = true;

        Console.WriteLine("-------------------------------------------");
        Console.WriteLine($"MISSÃO CONCLUÍDA? {(entendiMateria ? "SIM" : "NÃO")}");
        Console.WriteLine("O herói dominou os Tipos de Dados e as Operações!");
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("\nAperte qualquer tecla para fechar o livro da história...");
        Console.ReadKey();
   
