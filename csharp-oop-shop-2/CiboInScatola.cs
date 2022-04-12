using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop_2
{
    internal class CiboInScatola : Prodotto
    {

        //attributo statico
        private static string materiale = "Alluminio";

        private double peso;
        private bool aperto;
        public static int maxPeso = 300;

        public CiboInScatola(string nome, string descrizione, double peso) : base(nome, descrizione)
        {

            this.peso = peso;
            this.aperto = true;

        }
        public CiboInScatola(string nome, string descrizione, double peso, double prezzo, int iva) : base(nome, descrizione, prezzo, iva)
        {

            this.peso = peso;
            this.aperto = aperto;

        }

        public void ApriVasetto()
        {

            aperto = true;
            Console.WriteLine("snap");

        }

        //Classe statica, si usa per un elemento o per una funzione 
        //Che riguarda tutti gli eventuali oggetti.
        public static void CambiaMaterialeVasetto()
        {

            materiale = "Vetro";
            Console.WriteLine(materiale);

        }

        public void Mangia(double gMangiati)
        {

            if (this.peso > maxPeso)
            {

                Console.WriteLine("Ci dispiace ma non vendiamo scatole da piu di 300g");
                this.peso = 0;

            }

            if (this.peso - gMangiati > 0)
            {
                this.peso = this.peso - gMangiati;
                Console.WriteLine("Gnam , ho mangiato " + gMangiati + "g" + " ne rimangono " + this.peso);
            }
            else
            {

                this.peso = 0;
                Console.WriteLine("Hai finito la scatoletta. " + this.peso + " grammi rimasti");

            }

        }

        public new void StampaDati()
        {

            Console.WriteLine(base.PadLeft() + " - " + base.nome);
            Console.WriteLine("Il peso del sacchetto è: " + this.peso + "\n" + "vendiamo sacchetti da max: " + this.peso + "\n" + "Il sacchetto contiene: " + this.nome + " Descrizione: " + this.descrizione);

        }

    }
}
