using System;
using System.Collections.Generic;
using System.Linq;

namespace Progetto_Easy_Linq_Studente
{

    public class Esercizio1
    {
        public static void Main()
        {
            // 1 & 2. Inizializzazione della lista di studenti
            List<Studente> classe = new List<Studente>
            {
                new Studente { Nome = "Mario Rossi", Voto = 7.5 },
                new Studente { Nome = "Giulia Bianchi", Voto = 9.0 },
                new Studente { Nome = "Luca Verdi", Voto = 5.0 },
                new Studente { Nome = "Anna Neri", Voto = 8.5 },
                new Studente { Nome = "Paolo Gialli", Voto = 4.5 }
            };

            Console.WriteLine("--- ESERCIZIO 1: LINQ ---");

            // 3a. Media dei voti
            double mediaVoti = classe.Average(s => s.Voto);
            Console.WriteLine($"Media della classe: {mediaVoti:F2}");

            // 3b. Somma dei voti sufficienti
            double sommaSufficienti = classe
                .Where(s => s.Voto >= 6)
                .Sum(s => s.Voto);
            
            Console.WriteLine($"Somma dei voti sufficienti: {sommaSufficienti}");

            // 3c. Studenti che devono recuperare
            var daRecuperare = classe
                .Where(s => s.Voto < 6);
            Console.WriteLine("Studenti da recuperare: ");
            foreach (var studente in daRecuperare)
            {
                Console.WriteLine($"- {studente.Nome} (Voto: {studente.Voto})");
            }
            
            Console.WriteLine();
        }
    }

}