using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace efcore
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.BookId);
            builder.Property(x=> x.Title).HasMaxLength(50).IsRequired();
            builder.HasOne<Author>(e => e.Author).WithMany( o=> o.Books).HasForeignKey(x=> x.AuthorId);
        }
    }

}