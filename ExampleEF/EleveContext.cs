using Microsoft.EntityFrameworkCore;

namespace ExampleEF
{
    public class EleveContext :DbContext
    {
        public DbSet<Eleve> Eleves { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Eleve>()
                .ToTable("T_Eleve");
            modelBuilder.Entity<Eleve>()
                .HasKey(e => e.Id); // ID
            
            modelBuilder.Entity<Eleve>()
                .Property(b => b.Nom)
                .HasField("NOM_ELEVE")
                .IsRequired();
            
            modelBuilder.Entity<Eleve>()
                .Property(b => b.Note) //NOTE
                .IsRequired();
            
        }
    }
}