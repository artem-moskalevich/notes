using System.Data.Entity;
using MySql.Data.Entity;
using Notes.Data.Mapping;
using Notes.Data.Models;

namespace Notes.Data.Context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class NotesContext: DbContext
    {
        public NotesContext() : base("NotesContext")
        {
        }

        static NotesContext()
        {
            DbConfiguration.SetConfiguration(new MySqlEFConfiguration());
            Database.SetInitializer(new CreateDatabaseIfNotExists<NotesContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new NoteMap());
        }

        public DbSet<Note> Notes { get; set; }
    }
}