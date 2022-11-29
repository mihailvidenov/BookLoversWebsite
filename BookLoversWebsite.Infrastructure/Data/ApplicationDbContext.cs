using BookLoversWebsite.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookLoversWebsite.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserBook>()
                .HasKey(ub => new { ub.UserId, ub.BookId });

            builder.Entity<UserAuthor>()
                .HasKey(ua => new { ua.UserId, ua.AuthorId });

            builder.Entity<UserQuote>()
                .HasKey(uq => new { uq.UserId, uq.QuoteId });

            builder.Entity<User>()
                .Property(U => U.UserName)
                .HasMaxLength(20)
                .IsRequired();

            builder.Entity<User>()
                .Property(u => u.Email)
                .HasMaxLength(60)
                .IsRequired();

            base.OnModelCreating(builder);
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Quote> Quotes { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<Genre> Genres { get; set; }


    }
}