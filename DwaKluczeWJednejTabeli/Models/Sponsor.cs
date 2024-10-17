namespace DwaKluczeWJednejTabeli.Models
{
    public class Sponsor
    {
        public int SponsorId { get; set; }
        public string Nazwa { get; set; }
        public decimal Kwota { get; set; }
        public int DruzynaId { get; set; }
        public string Logo { get; set; } 
        public Druzyna Druzyna { get; set; }
    }
}