using System.ComponentModel.DataAnnotations;

namespace DT191G_moment45.Models
{
    public class Artist
    {
        // properties
        [Key]
        public int ArtistId { get; set; }
        [Required]
        public string Title { get; set; } //name of the artist



        // connects Artist table with Collection table
        public ICollection<Collection>? Collection { get; set; }
    }
}
