namespace DwaKluczeWJednejTabeli.Models
{
    public class Tabela
    {
        public int TabelaId { get; set; }
        public int DruzynaId { get; set; }
        public int RozegraneMecze { get; set; }
        //-------------------------------------
        public int Punkty { get; set; }
        //-------------------------------------
        public int StrzeloneBramki { get; set; }
        //-------------------------------------
        public int StraconeBramki { get; set; }
        //-------------------------------------
        public int Zwyciestwa { get; set; }
        public int Remisy { get; set; }
        public int Porazki { get; set; }
        public Druzyna Druzyna { get; set; }
    }
}