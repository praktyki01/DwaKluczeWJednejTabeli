namespace DwaKluczeWJednejTabeli.Models
{
    public class Zawodnik
    {
        public int ZawodnikId { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public string Pozycja { get; set; }
        public int DruzynaId { get; set; }
        public string Kraj { get; set; }

        public Druzyna Druzyna { get; set; }
        public ICollection<Statystyki> Statystykis { get; set; }
    }
}