/// Crea una Lista di oggetti il cui tipo, C, è composto da altri due tipi, A e B

using System.ComponentModel;

namespace ConsoleApp_FORUM
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
        public Tuple<string, int>? Attributo_C { get; set; }

        //Crea una tupla per contenere tipi diversi di dati
        public  Tuple<string, int> Metodo_C(string Nome, int Intero)
        {
           
            // costruisce un oggetto A e un oggetto B
            A Oggetto_A = new ();
            B Oggetto_B = new ();       

            //valorizza gli attributi
            Oggetto_A.Attributo_A = Nome;
            Oggetto_B.Attributo_B = Intero;

            //Costruisce il tipo C
            Attributo_C = Tuple.Create(Oggetto_A.Attributo_A, Oggetto_B.Attributo_B);

            return Attributo_C;
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
    
            C Oggetto_C = new ();
            List<C> Lista = new ();
            Lista.Add(Oggetto_C);

            string? Stringa_Utente;

            // Inizio popolamento lista con controllo in coda
            do
            {

                // Inserisce la stringa
                Console.Clear();
                Console.WriteLine("\tCONSOLE APP - FORUM McNeel ITALIA - RHINOCEROS\n");
                Console.Write("Inserisci una stringa:\t");

                Stringa_Utente = Console.ReadLine();

                //controllo la stringa inserita
                if (!string.IsNullOrEmpty(Stringa_Utente) && Stringa_Utente!="q")
                {
                    Stringa = Stringa_Utente;
                }


                //Inserisce la stringa e controlla che sia un intero
                while (!string.IsNullOrEmpty(Stringa_Utente) && Stringa_Utente != "q")
                {
                    Console.Clear();
                    Console.WriteLine("\tCONSOLE APP - FORUM McNeel ITALIA - RHINOCEROS\n");
                    Console.Write("Inserisci una numero intero:\t");
                    Stringa_Utente = Console.ReadLine();
                    if (int.TryParse(Stringa_Utente, out int value))
                    {
                        Intero = Convert.ToInt32(Stringa_Utente);
                        break;
                    }
                    else continue;
                    

                } 



                // Inserisce l'oggetto di tipo C in lista.
                Lista.Add(new C());


                //tira fuori l ultimo elemento e lo modifica
                C ultimo = Lista.Last();
                ultimo.Metodo_C(Stringa, Intero);

            } while (Stringa_Utente != "q");

            C primo = Lista.First();
            primo.Metodo_C("Forza Rhino", 7);

            //Visualizza la lista e restituisce il tempo impiegato
            Console.Clear();
            Console.WriteLine("\tCONSOLE APP - FORUM McNeel ITALIA - RHINOCEROS\n");
            Console.WriteLine("Hai inserito la seguente lista:\n");

            var watch = System.Diagnostics.Stopwatch.StartNew();    
            foreach (C item in Lista)
            {
                if (item.Attributo_C!=null)
                {
                    Console.WriteLine($"{item.Attributo_C.Item1} -- {item.Attributo_C.Item2}");
                }
                                
            }
            watch.Stop();


            Console.WriteLine();
            Console.WriteLine($"Tempo di esecuzione della lista: {watch.ElapsedMilliseconds} ms.\n");
            Console.WriteLine("Usare Rhino è divertente, ciao.");           
           
        }
    }
}