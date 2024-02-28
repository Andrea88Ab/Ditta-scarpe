using System.Collections.Generic;
using Ditta_Scarpe.Models;
using Microsoft.AspNetCore.Mvc;
// Assumi che esista un DataRepository per l'accesso ai dati

public class ArticoliController : Controller
{
    // Elenco Articoli
    public IActionResult Index()
    {
        var articoli = DataRepository.GetArticoli(); // Metodo fittizio per ottenere gli articoli
        return View(articoli);
    }

    // Dettagli Articolo
    public IActionResult Dettagli(int id)
    {
        var articolo = DataRepository.GetArticoloById(id); // Metodo fittizio per trovare un articolo per ID
        if (articolo == null)
        {
            return NotFound();
        }
        return View(articolo);
    }

    // Mostra la forma per aggiungere un nuovo articolo
    public IActionResult Aggiungi()
    {
        return View();
    }

    // Post per aggiungere un nuovo articolo
    [HttpPost]
    public IActionResult Aggiungi(Articolo articolo)
    {
        if (ModelState.IsValid)
        {
            DataRepository.AddArticolo(articolo); // Metodo fittizio per aggiungere l'articolo
            return RedirectToAction("Index");
        }
        return View(articolo);
    }

    // Mostra la forma per modificare un articolo
    public IActionResult Modifica(int id)
    {
        var articolo = DataRepository.GetArticoloById(id);
        if (articolo == null)
        {
            return NotFound();
        }
        return View(articolo);
    }

    // Post per modificare un articolo
    [HttpPost]
    public IActionResult Modifica(Articolo articolo)
    {
        if (ModelState.IsValid)
        {
            DataRepository.UpdateArticolo(articolo); // Metodo fittizio per aggiornare l'articolo
            return RedirectToAction("Index");
        }
        return View(articolo);
    }

    // Azione per eliminare logicamente un articolo
    public IActionResult Elimina(int id)
    {
        DataRepository.DeleteArticolo(id); // Metodo fittizio per eliminare logicamente l'articolo
        return RedirectToAction("Index");
    }
}

