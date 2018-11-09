using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTest
{
    [TestClass]
    public class ObslugaStringaTest
    {
        [TestMethod]
        public void WstawSpacjeTest()
        {
            // Arrange (przygotuj test)
            var zrodlo = "StółOgrodowy";
            var oczekiwana = "Stół Ogrodowy";
            var obslugaStringa = new ObslugaStringa();

            // Act (działaj)
            var aktualna = obslugaStringa.WstawSpacje(zrodlo);

            // Assert (potwierdz test)
            Assert.AreEqual(oczekiwana, aktualna); 
        }

        [TestMethod]
        public void WstawSpacjeTestZeSpacja() 
        {
            // Arrange (przygotuj test)
            var zrodlo = "Stół Ogrodowy";
            var oczekiwana = "Stół Ogrodowy";
            var obslugaStringa = new ObslugaStringa();

            // Act (działaj)
            var aktualna = obslugaStringa.WstawSpacje(zrodlo);

            // Assert (potwierdz test)
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}
