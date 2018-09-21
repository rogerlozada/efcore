using Microsoft.EntityFrameworkCore;

namespace efcore
{
    public class efcoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=BRSAO1PW-2632\SQLMAIN;Initial Catalog=EFCoreWebDemo;Integrated Security=False;User Id=sa;Password=******;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //posso adicionar um default scheme através dessa linha
            //modelBuilder.HasDefaultSchema("Producao");
            
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
