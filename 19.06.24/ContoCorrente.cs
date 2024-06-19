using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._06._24
{
    internal class ContoCorrente
    {
        public string NumeroConto { get; private set; }
        public string Intestatario { get; private set; }
        public double Saldo { get; private set; }
        private bool isOpen = false;

        // Costruttore
        public ContoCorrente(string numeroConto, string intestatario)
        {
            NumeroConto = numeroConto;
            Intestatario = intestatario;
            Saldo = 0;
        }

        // Metodo per aprire il conto
        public void ApriConto(double versamentoIniziale)
        {
            if (isOpen)
            {
                Console.WriteLine("Il conto è già aperto.");
            }
            else if (versamentoIniziale >= 1000)
            {
                Saldo = versamentoIniziale;
                isOpen = true;
                Console.WriteLine($"Conto aperto con versamento iniziale di {versamentoIniziale} euro.");
            }
            else
            {
                Console.WriteLine("Il versamento iniziale deve essere di almeno 1000 euro.");
            }
        }

        // Metodo per fare un versamento
        public void Versamento(double importo)
        {
            if (isOpen)
            {
                Saldo += importo;
                Console.WriteLine($"Versamento di {importo} euro effettuato con successo. Saldo disponibile: {Saldo} euro.");
            }
            else
            {
                Console.WriteLine("Il conto non è stato ancora aperto.");
            }
        }

        // Metodo per fare un prelievo
        public void Prelievo(double importo)
        {
            if (isOpen)
            {
                if (Saldo >= importo)
                {
                    Saldo -= importo;
                    Console.WriteLine($"Prelievo di {importo} euro effettuato con successo. Saldo disponibile: {Saldo} euro.");
                }
                else
                {
                    Console.WriteLine("Saldo insufficiente per il prelievo richiesto.");
                }
            }
            else
            {
                Console.WriteLine("Il conto non è stato ancora aperto.");
            }
        }
    }
}
