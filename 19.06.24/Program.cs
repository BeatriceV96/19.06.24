namespace _19._06._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creo un oggetto ContoCorrente
            ContoCorrente conto = new ContoCorrente("1234567", "Ginevra Delia");

            //Apro il contocorrente con un versamento iniziale 
            conto.ApriConto(1500); //soddisfo la richiesta di un primo versamento di almeno 1000 euro

            //Faccio il versamento
            conto.Versamento(500);

            //Faccio un prelievo
            conto.Prelievo(200);

            //Aspetto per visualizzare i risultati
            Console.WriteLine("Premi un tasto per continuare");
            Console.ReadKey();

            //Ricerca di un nome in un array
            CercaNomeInArray();

            //Somma e media di numeri in un array
            CalcolaSommaEMedia();
        }

        static void CercaNomeInArray()
        {
            //definiamo l'array
            int dimensioneArray = 3;
            string[] nomi = new string[dimensioneArray];

            //caricare array con i nomi
            Console.WriteLine("Inserisci 3 nomi:");
            for (int i = 0; i < dimensioneArray; i++)
            {
                Console.Write($"Nome {i + 1}: ");
                nomi[i] = Console.ReadLine();
            }

            // Specificare il nome da ricercare
            Console.Write("Inserisci il nome da ricercare: ");
            string nomeDaRicercare = Console.ReadLine();

            // Verificare se il nome è presente nell'array
            bool nomeTrovato = false;
            foreach (string nome in nomi)
            {
                if (nome.Equals(nomeDaRicercare, StringComparison.OrdinalIgnoreCase))
                {
                    nomeTrovato = true;
                    break;
                }
            }

            // Stampare il risultato della ricerca
            if (nomeTrovato)
            {
                Console.WriteLine($"Il nome {nomeDaRicercare} è presente nell'array.");
            }
            else
            {
                Console.WriteLine($"Il nome {nomeDaRicercare} non è presente nell'array.");
            }
        }

        static void CalcolaSommaEMedia()
        {
            // Prendere in input la dimensione dell'array
            Console.Write("Inserisci la dimensione dell'array: ");
            int dimensioneArray = int.Parse(Console.ReadLine());
            int[] numeri = new int[dimensioneArray];

            // Caricare l'array con numeri interi
            Console.WriteLine($"Inserisci {dimensioneArray} numeri interi:");
            for (int i = 0; i < dimensioneArray; i++)
            {
                Console.Write($"Numero {i + 1}: ");
                numeri[i] = int.Parse(Console.ReadLine());
            }

            // Calcolare la somma e la media dei numeri nell'array
            int somma = 0;
            for (int i = 0; i < dimensioneArray; i++)
            {
                somma += numeri[i];
            }
            double media = (double)somma / dimensioneArray;

            // Stampare la somma e la media
            Console.WriteLine($"La somma di tutti i numeri inseriti è: {somma}");
            Console.WriteLine($"La media di tutti i numeri inseriti è: {media}");
        }
    }
}
