namespace Kaczorek.BL
{
    public class PozycjaZamowienia
    {
        public PozycjaZamowienia()
        {

        }

        public PozycjaZamowienia(int pozycjaZmowieniaId)
        {
            PozycjaZmowieniaId = pozycjaZmowieniaId;
        }

        public int PozycjaZmowieniaId { get; private set; }
        public int Ilosc { get; set; }
        public int ProduktId { get; set; }
        public decimal? CenaZakupu { get; set; }

        // Metody
        /// <summary>
        /// Sprawdza dane pozycji zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zwalduj()
        {
            var poprawne = true;

            if (Ilosc <= 0)
                poprawne = false;
            if (ProduktId <= 0)
                poprawne = false;
            if (CenaZakupu == 0)
                poprawne = false;

            return poprawne;
        }

        /// <summary>
        /// Zapisuje element zamowienie
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // kod, który zapisuje zdefiniowane zamowienie
            return true;
        }

        /// <summary>
        /// Pobieramy jedną element zamowienia
        /// </summary>
        /// <param name="pozycjaZamowieniaId"></param>
        /// <returns></returns>
        public PozycjaZamowienia Pobierz(int pozycjaZamowieniaId)
        {
            //Kod który pobiera określony produkt
            return new PozycjaZamowienia();
        }
    }
}
