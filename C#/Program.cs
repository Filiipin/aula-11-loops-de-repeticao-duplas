﻿using System;
using System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gerador de confrontos");
            
            List<string> times = new List<string> { "Atlético-MG", "Cruzeiro", "América-MG", "Villa Nova" };

            for (int i = 0; i < times.Count; i++)
            {
                Console.WriteLine($"[{i}] {times[i]}");
            }

            Console.WriteLine("\nIda e Volta");
            int totalIdaVolta = 0;

            for (int i = 0; i < times.Count; i++)
            {
                for (int j = 0; j < times.Count; j++)
                {
                    if (i != j)
                    {
                        Console.WriteLine($"{times[i]} x {times[j]}");
                        totalIdaVolta++;
                    }
                }
            }
            Console.WriteLine($"Total de jogos (Ida e Volta): {totalIdaVolta}");

            Console.WriteLine("\nTurno único");
            int totalTurnoUnico = 0;

            for (int i = 0; i < times.Count; i++)
            {

                for (int j = i + 1; j < times.Count; j++)
                {
                    Console.WriteLine($"{times[i]} x {times[j]}");
                    totalTurnoUnico++;
                }
            }
            Console.WriteLine($"Total de jogos (Turno Único): {totalTurnoUnico}");

            Console.WriteLine("\nAdicionando o Tombense");
            times.Add("Tombense"); 

            Console.WriteLine("Nova lista de times com Tombense:");
            for (int i = 0; i < times.Count; i++)
            {
                Console.WriteLine($"[{i}] {times[i]}");
            }
        }
    }
}