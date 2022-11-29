using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoversWebsite.Infrastructure.Data.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(30)]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(30)]
        public string Nationality { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public string Biography { get; set; } = null!;


        public List<Book> Books { get; set; } = new List<Book>();

        public List<UserAuthor> UsersAuthors { get; set; } = new List<UserAuthor>();

        public List<Quote> Quotes { get; set; } = new List<Quote>();
    }
}
