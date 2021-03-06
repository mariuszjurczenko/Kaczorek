﻿using System.Collections.Generic;
using System.Linq;

namespace Kaczorek.BL
{
    public class KlientRepository
    {
        private AdresRepository adresRepository { get; set; }

        public KlientRepository()
        {
            adresRepository = new AdresRepository();
        }

        /// <summary>
        /// Pobieramy jednego klienta
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public Klient Pobierz(int klientId)
        {
            // Tworzymy instancję klasy klienta
            Klient klient = new Klient(klientId);
            klient.ListaAdresow = adresRepository.PobierzPoKlientId(klientId).ToList();

            //Kod który pobiera określonego klienta

            // Tymczasowo zakodowane wartosc, aby zwrocić klienta
            if (klientId ==1)
            {
                klient.Email = "marcin@dev-hobby.pl";
                klient.Imie = "Marcin";
                klient.Nazwisko = "Kowal";
            }

            return klient;
        }

        /// <summary>
        /// Pobieramy wszystkich klientów
        /// </summary>
        /// <returns></returns>
        public List<Klient> Pobierz()
        {
            //Kod który pobiera wszystkich klientów
            return new List<Klient>();
        }

        /// <summary>
        /// Zapisuje klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(Klient klient)
        {
            // kod, który zapisuje zdefiniowanego klienta
            var sukces = true;

            if (klient.MaZmiany && klient.DanePrawidlowe)
            {
                if (klient.JestNowy)
                {
                    // wywoływac procedure insert
                }
                else
                {
                    // wywoływac procedure update
                }
            }

            return sukces;
        }
    }
}
