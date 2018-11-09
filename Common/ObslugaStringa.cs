using System;

namespace Common
{
    public static class ObslugaStringa
    {
        public static string WstawSpacje(string zrodło)
        {
            string wynik = string.Empty;

            if (!String.IsNullOrWhiteSpace(zrodło))
            {
                foreach (var litera in zrodło)
                {
                    if (char.IsUpper(litera))
                    {
                        //przycinamy wszystkie spacje, które już tam są, a potem dodamy naszą spację.
                        wynik = wynik.Trim();
                        wynik += " ";
                    }
                    wynik += litera;
                }
                wynik = wynik.Trim();
            }
            return wynik;
        }
    }
}