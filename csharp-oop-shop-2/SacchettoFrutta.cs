using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop_2
{
    internal class SacchettoFrutta : Prodotto
    {

        //attributo statico
        private static string materiale = "Plastica";
        private protected string[] listaFrutta = { "Pesca", "Mela", "Banana", "Albicocca", "Mango", "Melone", "Papaya" };
        private protected string[] composizioneSacchetto = new string[5];
        private double pezziFrutta;
        private bool aperto;
        private int maxPezzi = 5;

        public SacchettoFrutta(string nomeFrutta, string descrizioneFrutta, double pezziFrutta) : base(nomeFrutta, descrizioneFrutta)
        {

            this.pezziFrutta = pezziFrutta;
            this.aperto = true;
            this.listaFrutta = listaFrutta;
            this.composizioneSacchetto = composizioneSacchetto;

        }
        public SacchettoFrutta(string nomeFrutta, string descrizioneFrutta, double pezziFrutta, double prezzoFrutta, int ivaFrutta) : base(nomeFrutta, descrizioneFrutta, prezzoFrutta, ivaFrutta)
        {

            this.pezziFrutta = pezziFrutta;
            this.aperto = aperto;
            this.listaFrutta = listaFrutta;
            this.composizioneSacchetto = composizioneSacchetto;

        }

        public void ApriVasetto()
        {

            aperto = true;
            Console.WriteLine("zap");

        }

 
        public static void CambiaMaterialeVasetto()
        {

            materiale = "Carta";
            Console.WriteLine(materiale);

        }


        public void ComponiSacchetto()
        {
            Console.WriteLine("Ecco la lista della frutta disponibile");
            for (int i = 0; i < listaFrutta.Length; i++)
            {

                Console.WriteLine(listaFrutta[i]);

            }

            Console.WriteLine("Di quanti frutti deve essere composto il sacchetto?");
            int numeroFrutti = int.Parse(Console.ReadLine());
            if (numeroFrutti > 5)
            {

                Console.WriteLine("Non puoi inserire piu di 5 pezzi di frutta");
                Console.WriteLine("Inserisci un numero di pezzi minore di 5");
                numeroFrutti = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < numeroFrutti; i++)
            {

                Console.WriteLine("Inserisci nome frutto da inserire");
                string fruttoDaInserire = Console.ReadLine();
                composizioneSacchetto[i] = fruttoDaInserire;

            }
            Console.WriteLine("Il tuo sacchetto è composto da: ");
            for (int i = 0; i < composizioneSacchetto.Length; i++)
            {

                Console.WriteLine(composizioneSacchetto[i]);
                Console.WriteLine("----------------------------");

            }


        }

        public void Mangia(int pezziMangiati)
        {

            if (this.pezziFrutta > maxPezzi)
            {

                Console.WriteLine("Ci dispiace ma non vendiamo scatole da piu di 5pz di frutta");
                this.pezziFrutta = 0;

            }

            if (this.pezziFrutta - pezziMangiati > 0)
            {
                this.pezziFrutta = this.pezziFrutta - pezziMangiati;
                Console.WriteLine("mastica mastica " + pezziMangiati + " ne restano " + this.pezziFrutta);
            }
            else
            {

                this.pezziFrutta = 0;
                Console.WriteLine("Capo non è infinita, sai? " + this.pezziFrutta + " pezzi di frutta rimasti");

            }

        }

        public new static void stampaDati()
        {




        }

    }
}
