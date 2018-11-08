using System;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class ProduktRepository
    {
        /// <summary>
        /// Pobieramy jedne produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        {
            // tworzenie isnstancji Produktu
            Produkt produkt = new Produkt(produktId);
            Object mojObiekt = new Object();
            Console.WriteLine("Obiekt : " + mojObiekt.ToString());
            Console.WriteLine("Produkt : " + produkt.ToString());

            //Kod który pobiera określony produkt

            // tymczasowo zakodowane wartosci, aby zwrocić produkt
            if (produktId == 5)
            {
                produkt.NazwaProduktu = "Klocki";
                produkt.Opis = "Klocki dla dzieci";
                produkt.AktualnaCena = 89.99M;
            }

            return produkt;
        }

        /// <summary>
        /// Pobieramy wszystkie produkty
        /// </summary>
        /// <returns></returns>
        public List<Produkt> Pobierz()
        {
            //Kod który pobiera wszystkich klientów
            return new List<Produkt>();
        }

        /// <summary>
        /// Zapisuje produkt
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // kod, który zapisuje zdefiniowany produkt
            return true;
        }
    }
}
