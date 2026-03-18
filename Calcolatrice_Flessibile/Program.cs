using System;

namespace Calcolatrice_Flessibile
{
    // --- LA CLASSE DELL'ESERCIZIO ---
    public class Esercizio2
    {
        // Metodo che accetta un Func
        public static double EseguiOperazione(double a, double b, Func<double, double, double> operazione)
        {
            return operazione(a, b);
        }

        // Metodo che contiene la logica del nostro programma
        public static void Esegui()
        {
            Console.WriteLine("--- ESERCIZIO 2: FUNC ---");

            Console.Write("Inserisci il primo numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inserisci il secondo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Chiamate al metodo passando le lambda
            double somma = EseguiOperazione(num1, num2, (x, y) => x + y);
            Console.WriteLine($"Addizione: {somma}");

            double prodotto = EseguiOperazione(num1, num2, (x, y) => x * y);
            Console.WriteLine($"Moltiplicazione: {prodotto}");

            double potenza = EseguiOperazione(num1, num2, (x, y) => Math.Pow(x, y));
            Console.WriteLine($"Potenza ({num1}^{num2}): {potenza}");
        }
    }

    // --- IL PUNTO DI INGRESSO (MAIN) ---
    class Program
    {
        static void Main(string[] args)
        {
            // Richiamiamo l'esercizio
            Esercizio2.Esegui();

            // Mettiamo in pausa la console alla fine per leggere i risultati
            Console.WriteLine("\nPremi INVIO per uscire...");
            Console.ReadLine();
        }
    }
}