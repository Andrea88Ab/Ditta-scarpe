namespace Ditta_Scarpe.Models
{
    public class ImmaginiArticolo
    {
        public int Id { get; set; }
        public int ArticoloId { get; set; }
        public string UrlImmagine { get; set; }
        public Articolo Articolo { get; set; }
    }

}
