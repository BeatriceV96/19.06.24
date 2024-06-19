using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._06._24
{
    public class ContoCorrente
    {
        // Proprietà per memorizzare il cognome del correntista
        private string _cognomeCorrentista;
        public string CognomeCorrentista
        {
            get { return _cognomeCorrentista; }
            set { _cognomeCorrentista = value; }
        }

        // Proprietà per memorizzare il nome del correntista
        private string _nomeCorrentista;
        public string NomeCorrentista
        {
            get { return _nomeCorrentista; }
            set { _nomeCorrentista = value; }
        }

        // Proprietà per memorizzare il saldo del conto
        private decimal _saldo = 0;
        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        // Proprietà per verificare se il conto è aperto
        private bool _contoAperto = false;
        public bool ContoAperto
        {
            get { return _contoAperto; }
            set { _contoAperto = value; }
        }

        // Costruttore di default
        public ContoCorrente()
        {

        }

        // Metodo per mostrare il menu iniziale e gestire le operazioni
        public void MenuInizialeStart()
        {
            // Visualizza le opzioni del menu
            Console.WriteLine("\n Scegli l'operazione da effettuare:");
            Console.WriteLine("1. APRI NUOVO CONTO CORRENTE");
            Console.WriteLine("2. EFFETTUA UN VERSAMENTO");
            Console.WriteLine("3. EFFETTUA UN PRELEVAMENTO");
            Console.WriteLine("4. ESCI");

            // Legge l'opzione scelta dall'utente
            int scelta = int.Parse(Console.ReadLine());

            // Gestisce l'operazione in base alla scelta dell'utente
            if (scelta == 1)
            {
                ApriNuovoContoCorrente();  // Apre un nuovo conto corrente
            }
            else if (scelta == 2)
            {
                EffettuaVersamento();  // Effettua un versamento
            }
            else if (scelta == 3)
            {
                EffettuaPrelevamento();  // Effettua un prelevamento
            }
            else if (scelta == 4)
            {
                Console.WriteLine("Chiusura programma in corso");  // Chiude il programma
            }
            else
            {
                Console.WriteLine("Voce non valida.");
                MenuInizialeStart();  // Mostra di nuovo il menu
            }
        }

        // Metodo per aprire un nuovo conto corrente
        private void ApriNuovoContoCorrente()
        {
            // Verifica se il conto è già aperto
            if (_contoAperto)
            {
                Console.WriteLine("Il conto è già aperto.");
                MenuInizialeStart();  // Ritorna al menu iniziale
                return;
            }

            // Richiede l'inserimento del cognome del correntista
            Console.WriteLine("Cognome Correntista: ");
            string cognome = Console.ReadLine();

            // Richiede l'inserimento del nome del correntista
            Console.WriteLine("Nome Correntista: ");
            string nome = Console.ReadLine();

            // Richiede l'inserimento del versamento iniziale
            Console.WriteLine("Inserisci un versamento iniziale (minimo 1000 euro): ");
            decimal versamentoIniziale = decimal.Parse(Console.ReadLine());

            // Verifica se il versamento iniziale è almeno 1000 euro
            if (versamentoIniziale >= 1000)
            {
                // Imposta i dati del correntista e il saldo iniziale
                _cognomeCorrentista = cognome;
                _nomeCorrentista = nome;
                _saldo = versamentoIniziale;
                _contoAperto = true;
                Console.WriteLine($"Conto corrente nr. 1234567 intestato a: {_cognomeCorrentista} {_nomeCorrentista} aperto correttamente con un saldo di {_saldo.ToString("N")} euro.");
            }
            else
            {
                Console.WriteLine("Il versamento iniziale deve essere di almeno 1000 euro.");
            }

            // Ritorna al menu iniziale
            MenuInizialeStart();
        }

        // Metodo per effettuare un prelevamento
        private void EffettuaPrelevamento()
        {
            // Verifica se il conto è aperto
            if (_contoAperto == false)
            {
                Console.WriteLine("E' necessario aprire un conto prima di effettuare un prelevamento");
            }
            else
            {
                // Richiede l'inserimento dell'importo da prelevare
                Console.WriteLine("Inserisci l'importo del prelevamento da effettuare: ");
                decimal importoPrelevato = decimal.Parse(Console.ReadLine());

                // Verifica se l'importo da prelevare è disponibile nel saldo
                if (importoPrelevato > _saldo)
                {
                    Console.WriteLine("Prelevamento non consentito!!!");
                }
                else
                {
                    Console.WriteLine("Prelevamento effettuato");
                    _saldo -= importoPrelevato;  // Aggiorna il saldo
                    Console.WriteLine($"Nuovo saldo del CC odierno: {_saldo.ToString("N")}");
                }
            }

            // Ritorna al menu iniziale
            MenuInizialeStart();
        }

        // Metodo per effettuare un versamento
        private void EffettuaVersamento()
        {
            // Verifica se il conto è aperto
            if (_contoAperto == false)
            {
                Console.WriteLine("E' necessario aprire un conto prima di effettuare un versamento");
            }
            else
            {
                // Richiede l'inserimento dell'importo da versare
                Console.WriteLine("Inserisci l'importo del versamento da effettuare: ");
                decimal importoVersato = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Versamento effettuato");
                _saldo += importoVersato;  // Aggiorna il saldo
                Console.WriteLine($"Nuovo saldo del CC odierno: {_saldo.ToString("N")}");
            }

            // Ritorna al menu iniziale
            MenuInizialeStart();
        }
    }
}
