namespace DwaKluczeWJednejTabeli.Models
{
    public class Mecz
    {
        public int MeczId { get; set; }
        public DateTime Data { get; set; }
        public int GoscieDruzynaId { get; set; }
        public Druzyna? GoscieDruzyna { get; set; }
        public int GospodarzeDruzynaId { get; set; }
        public Druzyna? GospodarzeDruzyna { get; set; }
        public string Wynik { get; set; }
        public ICollection<Sedzia> Sedzias { get; set; }
        public ICollection<Statystyki> Statystykis { get; set; }
    }
}