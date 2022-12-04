/// Crea una Lista di oggetti il cui tipo, C, è composto da altri due tipi, A e B

using System.ComponentModel;

namespace ForumMcNeel_Italia
{


    public class A
    {
        public string Attributo_A { get; set; }
        public A() 
        {
            Attributo_A = "";
        }
    }

    public class B
    {
        public int Attributo_B { get; set; }

    }
      public class C
    {
        //Crea una tupla per contenere tipi diversi di dati
        public Tuple<string, int> Metodo_C(string Nome, int Intero)
        {
            // costruisce un oggetto A e un oggetto B
            A Oggetto_A = new A();
            B Oggetto_B = new B();

            //valorizza gli attributi
            Oggetto_A.Attributo_A = Nome;
            Oggetto_B.Attributo_B = Intero;

            //Usa il tipo var per far dedurre al compilatore il tipo da memorizzare.
            var ValoreDiRitorno = Tuple.Create(Oggetto_A.Attributo_A, Oggetto_B.Attributo_B);

            //il metodo ritorna questo valore
            return ValoreDiRitorno;
        }
    }


    //La classe Program contiene il metodo entry point (Main) che sarà invocato all'avvio
    class Program
    {
        static void Main(string[] args)
        {
            // Inserisce una prima coppia di default: TRIBUTO A RHINOCEROS
            string Stringa = "Rhino";
            int Intero = 8;

            C Oggetto_C = new C();
            Oggetto_C.Metodo_C(Stringa, Intero);

            List<C> Lista = new List<C>();
            Lista.Add(Oggetto_C);

            // Inserisce la stringa

            string? Stringa_Utente;
            do
            {
                Stringa_Utente = "";

                Console.Clear();
                Console.WriteLine("Inserisci una numero intero:");

                Stringa_Utente = Console.ReadLine();

                //controllo la stringa inserita
                if (Stringa_Utente != "q" && Stringa_Utente != "" && Stringa_Utente != null)
                {
                    Stringa = Stringa_Utente;
                }
            } while (Stringa_Utente !=  "q");


            



            //Inserisce l'intero

            do
            {
                Stringa_Utente = "";

                Console.Clear();
                Console.WriteLine("Inserisci una numero intero:");

                Stringa_Utente = Console.ReadLine();

                //controllo la stringa inserita
                if (Stringa_Utente != "q" && Stringa_Utente != "" && Stringa_Utente != null && Stringa_Utente.)
                {
                    if (int.TryParse(Stringa_Utente, out int value))
                        Intero = Convert.ToInt32(Stringa_Utente);
                    else
                    {
                        Console.WriteLine("Imbecille, ho detto \"Inserisci un interno\"!");
                    }
                }

            } while (Stringa_Utente != "q");

            // Inserisce l'oggetto di tipo C in lista.
            Oggetto_C.Metodo_C(Stringa, Intero);
            Lista.Add(Oggetto_C);

            //Visualizza la lista e restituisce il tempo impiegato


            Console.Clear();
            Console.WriteLine("Hai inserito la seguente lista");

            var watch = System.Diagnostics.Stopwatch.StartNew();    
            foreach (C c in Lista)
            {
                Console.WriteLine($"{Oggetto_C.Metodo_C(Stringa,Intero)}");
            }
            watch.Stop();


            Console.WriteLine();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            Console.WriteLine("Usare Rhino è divertente, ciao.")           
           
        }
    }
}