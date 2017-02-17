namespace Notes.Data.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Notes.Data.Context.NotesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Notes.Data.Context.NotesContext";
        }

        protected override void Seed(Notes.Data.Context.NotesContext context)
        {
            var notes = new List<Note>();

            notes.Add(new Note() { Head = "Head-1", Body = "Body-1" });
            notes.Add(new Note() { Head = "Head-2", Body = "Body-2" });
            notes.Add(new Note() { Head = "Head-3", Body = "Body-3" });

            context.Notes.AddRange(notes);
            context.SaveChanges();
        }
    }
}
