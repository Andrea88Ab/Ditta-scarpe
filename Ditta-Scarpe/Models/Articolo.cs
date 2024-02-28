namespace Ditta_Scarpe.Models
{
    public class Articolo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Prezzo { get; set; }
        public string Descrizione { get; set; }
        public string ImmagineCopertina { get; set; }
        // Assumi che ci siano due immagini aggiuntive
        public string ImmagineAggiuntiva1 { get; set; }
        public string ImmagineAggiuntiva2 { get; set; }
    }


}
