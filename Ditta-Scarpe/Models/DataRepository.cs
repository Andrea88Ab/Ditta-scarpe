using Ditta_Scarpe.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ditta_Scarpe.Models
{
    public static class DataRepository
    {
        static DataRepository()
        {
            Articoli = new List<Articolo>
        {
            new Articolo { Id = 1, Nome = "Scarpe Sportive 1", Prezzo = 100.00M, Descrizione = "Descrizione delle Scarpe Sportive 1", ImmagineCopertina = "/images/scarpesportive1.jpg", ImmagineAggiuntiva1 = "/images/scarpesportive1a.jpg", ImmagineAggiuntiva2 = "/images/scarpesportive1b.jpg" },
            new Articolo { Id = 2, Nome = "Scarpe Sportive 2", Prezzo = 110.00M, Descrizione = "Descrizione delle Scarpe Sportive 2", ImmagineCopertina = "/images/scarpesportive2.jpg", ImmagineAggiuntiva1 = "/images/scarpesportive2a.jpg", ImmagineAggiuntiva2 = "/images/scarpesportive2b.jpg" },
            new Articolo { Id = 3, Nome = "Scarpe da Corsa 1", Prezzo = 120.00M, Descrizione = "Descrizione delle Scarpe da Corsa 1", ImmagineCopertina = "/images/scarpacorsa1.jpg", ImmagineAggiuntiva1 = "/images/scarpacorsa1a.jpg", ImmagineAggiuntiva2 = "/images/scarpacorsa1b.jpg" },
            new Articolo { Id = 4, Nome = "Scarpe da Corsa 2", Prezzo = 130.00M, Descrizione = "Descrizione delle Scarpe da Corsa 2", ImmagineCopertina = "/images/scarpacorsa2.jpg", ImmagineAggiuntiva1 = "/images/scarpacorsa2a.jpg", ImmagineAggiuntiva2 = "/images/scarpacorsa2b.jpg" },
            new Articolo { Id = 5, Nome = "Scarpe da Trekking 1", Prezzo = 140.00M, Descrizione = "Descrizione delle Scarpe da Trekking 1", ImmagineCopertina = "/images/scarpadatrekking1.jpg", ImmagineAggiuntiva1 = "/images/scarpadatrekking1a.jpg", ImmagineAggiuntiva2 = "/images/scarpadatrekking1b.jpg" },
            new Articolo { Id = 6, Nome = "Scarpe da Trekking 2", Prezzo = 150.00M, Descrizione = "Descrizione delle Scarpe da Trekking 2", ImmagineCopertina = "/images/scarpadatrekking2.jpg", ImmagineAggiuntiva1 = "/images/scarpadatrekking2a.jpg", ImmagineAggiuntiva2 = "/images/scarpadatrekking2b.jpg" },
            new Articolo { Id = 7, Nome = "Scarpe da Calcio 1", Prezzo = 160.00M, Descrizione = "Descrizione delle Scarpe da Calcio 1", ImmagineCopertina = "/images/scarpadacalcio1.jpg", ImmagineAggiuntiva1 = "/images/scarpadacalcio1a.jpg", ImmagineAggiuntiva2 = "/images/scarpadacalcio1b.jpg" },
            new Articolo { Id = 8, Nome = "Scarpe da Calcio 2", Prezzo = 170.00M, Descrizione = "Descrizione delle Scarpe da Calcio 2", ImmagineCopertina = "/images/scarpadacalcio2.jpg", ImmagineAggiuntiva1 = "/images/scarpadacalcio2a.jpg", ImmagineAggiuntiva2 = "/images/scarpadacalcio2b.jpg" },
            new Articolo { Id = 9, Nome = "Scarpe Casual 1", Prezzo = 180.00M, Descrizione = "Descrizione delle Scarpe Casual 1", ImmagineCopertina = "/images/scarpacasual1.jpg", ImmagineAggiuntiva1 = "/images/scarpacasual1a.jpg", ImmagineAggiuntiva2 = "/images/scarpacasual1b.jpg" },
            new Articolo { Id = 10, Nome = "Scarpe Casual 2", Prezzo = 190.00M, Descrizione = "Descrizione delle Scarpe Casual 2", ImmagineCopertina = "/images/scarpacasual2.jpg", ImmagineAggiuntiva1 = "/images/scarpacasual2a.jpg", ImmagineAggiuntiva2 = "/images/scarpacasual2b.jpg" }
        };
        }

        public static List<Articolo> Articoli { get; private set; }

        public static List<Articolo> GetArticoli()
        {
            return Articoli;
        }

        public static Articolo GetArticoloById(int id)
        {
            return Articoli.FirstOrDefault(a => a.Id == id);
        }

        public static void AddArticolo(Articolo articolo)
        {
            articolo.Id = Articoli.Max(a => a.Id) + 1;
            Articoli.Add(articolo);
        }

        public static void UpdateArticolo(Articolo articoloToUpdate)
        {
            var articolo = GetArticoloById(articoloToUpdate.Id);
            if (articolo != null)
            {
                articolo.Nome = articoloToUpdate.Nome;
                articolo.Prezzo = articoloToUpdate.Prezzo;
                articolo.Descrizione = articoloToUpdate.Descrizione;
                articolo.ImmagineCopertina = articoloToUpdate.ImmagineCopertina;
                articolo.ImmagineAggiuntiva1 = articoloToUpdate.ImmagineAggiuntiva1;
                articolo.ImmagineAggiuntiva2 = articoloToUpdate.ImmagineAggiuntiva2;
            }
        }

        public static void DeleteArticolo(int id)
        {
            var articolo = GetArticoloById(id);
            if (articolo != null)
            {
                Articoli.Remove(articolo);
            }
        }
    }
}
