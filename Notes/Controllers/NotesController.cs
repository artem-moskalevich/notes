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
    }
}