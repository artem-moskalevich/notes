using System.Collections.Generic;
using System.Linq;
using Notes.Data.Context;
using Notes.Data.Models;
using Notes.Interfaces;

namespace Notes.Services
{
    public class NoteService: INoteService
    {
        private readonly NotesContext _context;
        private string key = "5y90jgjgvesl";

        public NoteService(NotesContext context)
        {
            _context = context;
        }

        public List<Note> Get()
        {
            return _context.Notes.ToList();
        }

        public void Save(Note note)
        {
            _context.Notes.Add(note);
            _context.SaveChanges();
        }

        public void Synchronize()
        {
            throw new System.NotImplementedException();
        }
    }
}