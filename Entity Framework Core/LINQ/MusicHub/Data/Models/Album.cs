using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace MusicHub.Data.Models
{
    public class Album
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public decimal Price => Songs.Sum(x => x.Price);

        
        public int? ProducerId { get; set; }

        [ForeignKey(nameof(ProducerId))]
        public virtual Producer? Producer { get; set; }

        public ICollection<Song> Songs { get; set; }
    }
}