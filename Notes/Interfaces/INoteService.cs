using System.Collections.Generic;
using Notes.Data.Models;

namespace Notes.Interfaces
{
    public interface INoteService
    {
        List<Note> Get();
        void Put();
        void Synchronize();
    }
}