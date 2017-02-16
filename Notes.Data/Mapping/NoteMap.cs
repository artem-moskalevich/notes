using System.Data.Entity.ModelConfiguration;
using Notes.Data.Models;

namespace Notes.Data.Mapping
{
    public class NoteMap: EntityTypeConfiguration<Note>
    {
        public NoteMap()
        {
            ToTable("Notes");

            HasKey(x => x.Id);

            Property(p => p.Id).HasColumnName("id");
            Property(p => p.Head).HasColumnName("head").HasMaxLength(250);
            Property(p => p.Body).HasColumnName("body").HasMaxLength(1000);
        }
    }
}