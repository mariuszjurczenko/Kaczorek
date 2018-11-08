namespace Kaczorek.BL
{
    public abstract class KlasaBazowa
    {
        public bool JestNowy { get; set; }
        public bool MaZmiany { get; set; }
        public StanObiektuOpcje StanObiektu { get; set; }

        public bool DanePrawidlowe
        {
            get
            {
                return Zwalduj();
            }
        }

        public abstract bool Zwalduj();

    }

    public enum StanObiektuOpcje
    {
        Atywny,
        Usuniety
    }
}