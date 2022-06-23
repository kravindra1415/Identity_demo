using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Data.Models
{
    [Table(nameof(Movie),Schema="bollywood")]
    public class Movie
    {
        public int Id { get; set; }

        [Unicode(false)]
        [StringLength(250)]
        public string Title { get; set; } = null!;

        public long? Budget { get; set; }

        public DateTime? ReleasedYear { get; set; }
    }
}
