namespace Kaczorek.BL
{
    public class WyswietlaniePozycjZamowienia
    {
        public int PozycjaZamowieniaId { get; private set; }
        public int Ilosc { get; set; }
        public string NazwaProduktu { get; set; }
        public decimal? CenaZakupu { get; set; }
    }
}