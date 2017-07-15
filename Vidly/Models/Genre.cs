using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Genre
    {
        public byte Id { get; set; }

        [StringLength(50)]
        [Display(Name = "Gênero")]
        public string Name { get; set; }
    }
}