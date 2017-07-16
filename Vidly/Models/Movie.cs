using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Nome { get; set; }
        
        [Display(Name = "Gênero")]
        public Genre Genre { get; set; }

        [Display(Name = "Gênero")]
        public byte GenreId { get; set; }

        [Display(Name = "Data Adicionado")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Data de Lançamento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Em estoque")]
        public byte NumberInStock { get; set; }
    }
}