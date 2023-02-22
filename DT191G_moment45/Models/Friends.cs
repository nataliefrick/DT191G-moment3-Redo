using System.ComponentModel.DataAnnotations;

namespace DT191G_moment45.Models
{
    public class Friends
    {
        // properties
        [Key]
        public int FriendId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty; //name of the person borrowing the album
        public string? Email { get; set; }


        // connects Friend table with Borrowed table
        public ICollection<Borrowed>? Borrowed { get; set; }
    }
}
