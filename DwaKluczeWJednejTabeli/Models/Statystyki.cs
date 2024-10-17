using System.Numerics;

namespace DwaKluczeWJednejTabeli.Models
{
    public class Statystyki
    {
        public int StatystykiId { get; set; }
        public int ZawodnikId { get; set; }
        public Zawodnik Zawodnik { get; set; }
        public int MeczId { get; set; }
        public Mecz Mecz { get; set; }
        public int Gole { get; set; }
        public int Asysty { get; set; }
        public int ZolteKartki { get; set; }
        public int CzerwoneKartki { get; set; }
    }
}