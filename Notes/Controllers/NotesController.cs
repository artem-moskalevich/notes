using System.Web.Mvc;
using Notes.Interfaces;

namespace Notes.Controllers
{
    public class NotesController : Controller
    {
        private readonly INoteService _noteService;

        public NotesController(INoteService noteService)
        {
            _noteService = noteService;
        }

        public ActionResult Index()
        {
            var notes = _noteService.Get();
            return View(notes);
        }

        [HttpPost]
        public ActionResult Create(Notes.Data.Models.Note note)
        {
            _noteService.Save(note);
            return RedirectToAction("Index");
        }

        public ActionResult Sync()
        {
            _noteService.Synchronize();
            return RedirectToAction("Index");
        }
    }
}