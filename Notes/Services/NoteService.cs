using System.Collections.Generic;
using Notes.Interfaces;
using Notes.Models;

namespace Notes.Services
{
    public class NoteService: INoteService
    {
        List<Note> INoteService.Get()
        {
            return new List<Note>()
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
            };
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