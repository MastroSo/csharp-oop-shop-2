using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop_2
{
    internal class Elettrodomestico : Prodotto
    {

       
        private string marca;
        private string modello;
        private int annoProd;
        private string colore;
        private string matricola;

        public bool accesa;

        
        public Elettrodomestico(string marca, string modello, int annoProd, string colore) : base(marca, modello)
        {
            this.marca = marca;
            this.modello = modello;
            this.annoProd = annoProd;
            this.colore = colore;
            accesa = false;
        }

        public Elettrodomestico(string marca, string modello, int annoProd, string colore, double prezzo, int iva) : base(marca, modello, prezzo, iva)
        {

            this.marca = marca;
            this.modello = modello;
            this.annoProd = annoProd;
            this.colore = colore;
            accesa = false;

        }

        
        public void Accenditi()
        {
            Console.WriteLine("Please and aspetta");
            accesa = true;
        }

        //Metodo
        public void CambiaColore(string colore)
        {

            this.colore = colore;

        }

        //Metodo
        public new void StampaDati()
        {
            Console.WriteLine("------- Elettrodomestico -------");
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Modello: " + modello);
            Console.WriteLine("Anno di produzione: " + annoProd);
            Console.WriteLine("Colore: " + colore);
            Console.WriteLine("Matricola: " + matricola);
        }

        //Metodo
        public void AssegnaCodiceMatricola(string matricola)
        {
            if (matricola.Length == 8)
            {
                this.matricola = matricola;

            }
            else
            {
                Console.WriteLine("Mi dispiace ma la matricola deve essere di 8 cifre");
            }
        }

    }
}
