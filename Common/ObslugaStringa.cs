using System;

namespace Common
{
    public class ObslugaStringa
    {
        public string WstawSpacje(string zrodło)
        {
            string wynik = string.Empty;

            if (!String.IsNullOrWhiteSpace(zrodło))
            {
                foreach (var litera in zrodło)
                {
                    if (char.IsUpper(litera))
                    {
                        wynik += " ";
                    }
                    wynik += litera;
                }
            }
            return wynik;
        }
    }
}