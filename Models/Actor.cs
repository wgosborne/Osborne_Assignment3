using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Osborne_Assignment3.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Gender { get; set; }

        [Required]
        public string Name { get; set; }

        public int Age { get; set; }

        [Url]
        public string? Hyperlink { get; set; }

        public byte[]? Photo { get; set; }

        [ForeignKey("Movies")]
        public int? MovieId { get; set; }
        public Movie? Movie { get; set; }
    }
}
