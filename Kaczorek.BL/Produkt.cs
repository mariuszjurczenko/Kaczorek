﻿using System;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class Produkt : KlasaBazowa
    {
        public Produkt()
        {
                
        }

        public Produkt(int produktId)
        {
            ProduktId = produktId;
        }

        public int ProduktId { get; private set; }
        public Decimal? AktualnaCena { get; set; }
        public string Opis { get; set; }

        private string _NazwaProduktu;
        public string NazwaProduktu
        {
            get { return _NazwaProduktu; }
            set { _NazwaProduktu = value; }
        }



        // Metody
        /// <summary>
        /// Sprawdza dane produktu
        /// </summary>
        /// <returns></returns>
        public override bool Zwalduj()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace(NazwaProduktu))
                poprawne = false;
            if (AktualnaCena == null)
                poprawne = false;

            return poprawne;
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

        /// <summary>
        /// Pobieramy jedne produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        {
            //Kod który pobiera określony produkt
            return new Produkt();
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

        public override string ToString()
        {
            return NazwaProduktu;
        }
    }
}
