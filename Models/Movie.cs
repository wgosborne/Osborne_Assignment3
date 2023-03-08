using System.ComponentModel.DataAnnotations;
namespace Osborne_Assignment3.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [Url]
        public string? Hyperlink { get; set; }

        public string Genre { get; set; }

        public byte[]? Poster { get; set; }

        public string Year { get; set; }


    }
}
