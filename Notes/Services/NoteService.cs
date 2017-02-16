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

        public NoteService(NotesContext context)
        {
            _context = context;
        }

        public List<Note> Get()
        {
            return _context.Notes.ToList();
            /*return new List<Note>()
            {
                new Note()
                {
                    Id = 1,
                    Head = "Head-1",
                    Body = "Body-1"
                },
                new Note()
                {
                    Id = 2,
                    Head = "Head-2",
                    Body = "Body-2"
                },
                new Note()
                {
                    Id = 3,
                    Head = "Head-3",
                    Body = "Body-3"
                }
            };*/
        }

        public void Put()
        {
            throw new System.NotImplementedException();
        }

        public void Synchronize()
        {
            throw new System.NotImplementedException();
        }
    }
}