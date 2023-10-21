using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TheNote.Models;

namespace TheNote.Controllers;

public class NoteController : Controller
{
    private List<Note> notes = new List<Note>();

    public ActionResult Index()
    {
        // Отримуємо список усіх заміток та відображаємо їх на сторінці
        return View(notes);
    }

    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Create(Note note)
    {
        // Додаємо нову замітку до списку
        note.CreatedDate = DateTime.Now;
        notes.Add(note);
        return RedirectToAction("Index");
    }
}

