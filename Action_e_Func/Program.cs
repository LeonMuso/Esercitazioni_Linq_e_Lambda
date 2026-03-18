using System;
using System.Linq;

namespace Action_e_Func
{
    // --- LA CLASSE DELL'ESERCIZIO ---
    public class Esercizio3
    {
        // 1. Metodo che combina Func (per filtrare) e Action (per eseguire l'output)
        public static void ElaboraArray(int[] numeri, Func<int, bool> filtro, Action<int> stampa)
        {
            foreach (int numero in numeri)
            {
                // Se il numero passa il filtro (il Func restituisce true)...
                if (filtro(numero))
                {
                    // ...allora esegui l'azione di stampa (l'Action)
                    stampa(numero);
                }
            }
        }

        // 2. Metodo che contiene la logica del nostro programma
        public static void Esegui()
        {
            Console.WriteLine("--- ESERCIZIO 3: ACTION E FUNC ---");

            // Creazione array da 1 a 20 usando LINQ per comodità
            int[] dati = Enumerable.Range(1, 20).ToArray();

            // Prima esecuzione: filtro i pari, stampo il numero puro
            Console.WriteLine("Numeri pari:");
            ElaboraArray(
                dati,
                n => n % 2 == 0,
                n => Console.WriteLine(n)
            );

            // Seconda esecuzione: filtro i > 10, stampo con string interpolation
            Console.WriteLine("\nNumeri maggiori di 10:");
            ElaboraArray(
                dati,
                n => n > 10,
                n => Console.WriteLine($"Numero trovato: {n}")
            );
        }
    }

    // --- IL PUNTO DI INGRESSO (MAIN) ---
    class Program
    {
        static void Main(string[] args)
        {
            // Richiamiamo l'esercizio
            Esercizio3.Esegui();

            // Mettiamo in pausa la console alla fine per leggere i risultati
            Console.WriteLine("\nPremi INVIO per uscire...");
            Console.ReadLine();
        }
    }
}