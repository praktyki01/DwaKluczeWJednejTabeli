using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace DwaKluczeWJednejTabeli.Models
{
    public class Druzyna
    {
        public int DruzynaId { get; set; }
        public string Nazwa { get; set; }
        public int RokZalozenia { get; set; }
        public string Miasto { get; set; }
        public string Trener { get; set; }
        public string Logo { get; set; }

        public ICollection<Zawodnik> Zawodniks { get; set; }        
        public ICollection<Sponsor> Sponsors { get; set; }
        public ICollection<Sedzia> Sedzias { get; set; }
        [InverseProperty("GoscieDruzyna")]
        public ICollection<Mecz> MeczGoscies { get; set; }
        [InverseProperty("GospodarzeDruzyna")]
        public ICollection<Mecz> MeczGospodarzes { get; set; }
    }
}