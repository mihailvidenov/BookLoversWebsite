using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoversWebsite.Infrastructure.Data.Models
{
    public class User : IdentityUser
    {
        public List<UserBook> UsersBooks { get; set; } = new List<UserBook>();

        public List<UserAuthor> UsersAuthors { get; set; } = new List<UserAuthor>();

        public List<UserQuote> UsersQuotes { get; set; } = new List<UserQuote>();
    }
}
