namespace DwaKluczeWJednejTabeli.Models
{
    public class Sedzia
    {
        public int SedziaId { get; set; }
        public string Imie { get; set; }
        public int WystawioneZolteKartki { get; set; }
        public ICollection<Mecz> Mecz { get; set; }
    }
}