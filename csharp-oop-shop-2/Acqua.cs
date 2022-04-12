using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop_2
{
    internal class Acqua : Prodotto
    {

        //attributi specifici di bevanda
        private double litri;
        private int ph;
        private string sorgente;
        public string materialeContenitore;
        public static double maxLitri = 1.5;

        //Costruttore specifico di bevanda senza prezzo e iva che usa il costruttore senza prezzo ed iva di prodotto
        public Acqua(string nomeBevanda, string descrizione, double litri, int ph, string sorgente) : base(nomeBevanda, descrizione)
        {

            this.litri = litri;
            this.ph = ph;
            this.sorgente = sorgente;

        }

        //Costruttore specifico di bevanda che usa il costruttore completo di prodotto
        public Acqua(string nomeBevanda, string descrizione, double litri, int ph, string sorgente, double prezzo, int iva) : base(nomeBevanda, descrizione, prezzo, iva)
        {

            this.litri = litri;
            this.ph = ph;
            this.sorgente = sorgente;

        }

        //Con new, faccio un override del metodo nome esteso di prodotto, perchè questo metodo
        //esisteva gia in prodotto (Sovrascrivete il metodo)
        public new void StampaDati()
        {
            //CODICE PAD - NOME - LITRI
            Console.WriteLine(base.PadLeft() + " - " + base.nome);
            Console.WriteLine("Il ph dell'acqua è: " + this.ph + "\n" + "La sorgente dell'acqua è: " + this.sorgente + "\n" + "la bottiglia contiene: " + this.litri + " Litri");


        }
        //I metodi specifici della classe bevanda
        //se mettessi private il metodo sarebbe superfluo poichè la bevanda si beve da fuori
        public void Bevi(double litriBevuti)
        {

            if (this.litri > maxLitri)
            {

                Console.WriteLine("Ci dispiace ma non vendiamo bottiglie da piu di un litro e mezzo");
                this.litri = 0;

            }

            if (this.litri - litriBevuti > 0)
            {
                this.litri = this.litri - litriBevuti;
                Console.WriteLine("Non puoi sentirlo ma sto bevendo " + litriBevuti + " ne rimangono " + this.litri);
            }
            else
            {

                this.litri = 0;
                Console.WriteLine("Hai finito la bottiglia. " + this.litri + " litri rimasti");

            }

        }

        public void Riempi(double litriDaInserire)
        {

            if (litriDaInserire > this.litri)
            {
                this.litri = 1.5;
                Console.WriteLine("La bottiglia è piena, ha trabboccato");

            }
            else if (litriDaInserire < this.litri)
            {

                Console.WriteLine("La bottiglia non è ancora piena");

            }
            else
            {

                Console.WriteLine("Bottiglia piena, 1.5 litri");

            }

        }

        public void Svuota()
        {

            this.litri = 0;
            Console.WriteLine("Hai svuotato la bottiglia");

        }

        public static void DaLitriAGalloni(string litri)
        {

            double litriG = double.Parse(litri);
            if (litriG > 0)
            {

                double galloni = litriG * 3.785;
                galloni = galloni * litriG;
                Console.WriteLine(galloni);

            }
            else
            {
                double galloni = litriG / 3.785;
                galloni *= litriG;
                Console.WriteLine(galloni + " Galloni");
            }

        }



    }
}
    