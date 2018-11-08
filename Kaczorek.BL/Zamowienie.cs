using System;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class Zamowienie : KlasaBazowa
    {
        #region konstruktory
        public Zamowienie()
        {

        }

        public Zamowienie(int zamowienieId)
        {
            ZamowienieId = zamowienieId;
        }
        #endregion

        #region właściwości
        public int ZamowienieId { get; private set; }
        public DateTimeOffset? DataZamowienia { get; set; }

        public List<PozycjaZamowienia> pozycjeZamowienia { get; set; }
        public int KlientId { get; set; }
        public int AdresDostawyId { get; set; }
        #endregion

        #region metody
        // Metody
        /// <summary>
        /// Sprawdza dane zamowienia
        /// </summary>
        /// <returns></returns>
        public override bool Zwalduj()
        {
            var poprawne = true;

            if (DataZamowienia == null)
                poprawne = false;

            return poprawne;
        }

        /// <summary>
        /// Zapisuje zamowienie
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // kod, który zapisuje zdefiniowane zamowienie
            return true;
        }

        /// <summary>
        /// Pobieramy jedno zamowienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            //Kod który pobiera określony produkt
            return new Zamowienie();
        }

        /// <summary>
        /// Pobieramy wszystkie zamowienia
        /// </summary>
        /// <returns></returns>
        public List<Zamowienie> Pobierz()
        {
            //Kod który pobiera wszystkie zamowienia
            return new List<Zamowienie>();
        }

        public override string ToString()
        {
            return DataZamowienia.Value.Date + " (" + ZamowienieId + ")";
        }

        #endregion
    }
}
