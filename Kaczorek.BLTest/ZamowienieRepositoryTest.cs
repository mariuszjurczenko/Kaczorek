using System;
using System.Collections.Generic;
using Kaczorek.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kaczorek.BLTest
{
    [TestClass]
    public class ZamowienieRepositoryTest
    {
        [TestMethod]
        public void PobierzZamowienieTest()
        {
            // Arrange (przygotuj test)
            var zamowienieRepository = new ZamowienieRepository();
            var oczekiwane = new Zamowienie(10)
            {
                DataZamowienia = new DateTimeOffset(2018, 4, 20, 11, 00, 00, new TimeSpan(7, 0, 0))
            };

            // Act (działaj)
            var aktualne = zamowienieRepository.Pobierz(10);


            // Assert (potwierdz test)
            Assert.AreEqual(oczekiwane.ZamowienieId, aktualne.ZamowienieId);
            Assert.AreEqual(oczekiwane.DataZamowienia, aktualne.DataZamowienia);
        }

        [TestMethod]
        public void PobierzZamowienieDoWyswietleniaTest()
        {
            // Arrange
            var zamowienieRepository = new ZamowienieRepository();
            var oczekiwana = new WyswietlanieZamowienia()
            {
                Imie = "Jacek",
                Nazwisko = "Kowal",
                DataZamowienia = new DateTimeOffset(2018, 5, 21, 12, 00, 00, new TimeSpan(5, 0, 0)),
                AdresDostawy = new Adres()
                {
                    AdresTyp = 2,
                    Ulica = "Mila",
                    Miasto = "Katowice",
                    Kraj = "Polska",
                    KodPocztowy = "44-400"
                },
                WyswietlaniePozycjZamowieniaLista = new List<WyswietlaniePozycjZamowienia>()
                {
                    new WyswietlaniePozycjZamowienia()
                    {
                        NazwaProduktu = "Stol",
                        CenaZakupu = 300.50M,
                        Ilosc = 10
                    },
                    new WyswietlaniePozycjZamowienia()
                    {
                        NazwaProduktu = "blat",
                        CenaZakupu = 50.33M,
                        Ilosc = 5
                    }
                }
            };

            // Act
            var aktualna = zamowienieRepository.PobierzZamowienieDoWyswietlenia(10);

            // Assert
            Assert.AreEqual(oczekiwana.ZamowienieId, aktualna.ZamowienieId);
            Assert.AreEqual(oczekiwana.DataZamowienia, aktualna.DataZamowienia);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

            Assert.AreEqual(oczekiwana.AdresDostawy.AdresTyp, aktualna.AdresDostawy.AdresTyp);
            Assert.AreEqual(oczekiwana.AdresDostawy.Ulica, aktualna.AdresDostawy.Ulica);
            Assert.AreEqual(oczekiwana.AdresDostawy.Miasto, aktualna.AdresDostawy.Miasto);
            Assert.AreEqual(oczekiwana.AdresDostawy.KodPocztowy, aktualna.AdresDostawy.KodPocztowy);
            Assert.AreEqual(oczekiwana.AdresDostawy.Kraj, aktualna.AdresDostawy.Kraj);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjZamowieniaLista[i].NazwaProduktu, aktualna.WyswietlaniePozycjZamowieniaLista[i].NazwaProduktu);
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjZamowieniaLista[i].Ilosc, aktualna.WyswietlaniePozycjZamowieniaLista[i].Ilosc);
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjZamowieniaLista[i].CenaZakupu, aktualna.WyswietlaniePozycjZamowieniaLista[i].CenaZakupu);
            }
        }
    }
}