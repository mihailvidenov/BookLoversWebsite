using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoversWebsite.Infrastructure.Data.Models
{
    public class UserQuote
    {
        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        [Required]
        public int QuoteId { get; set; }

        [ForeignKey(nameof(QuoteId))]
        public Quote Quote { get; set; } = null!;
    }
}
