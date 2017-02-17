using System.Collections.Generic;
using Notes.Data.Models;

namespace Notes.Interfaces
{
    public interface INoteService
    {
        List<Note> Get();
        void Save(Note note);
        void Synchronize();
    }
}