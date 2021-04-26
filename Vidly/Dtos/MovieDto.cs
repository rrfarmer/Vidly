using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a Movie name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Please enter Stock amount between 1 & 20.")]
        [Range(1, 20)]
        public int NumberInStock { get; set; }

        //public Genre Genre { get; set; }

        [Required(ErrorMessage = "Please select a Genre.")]
        public int GenreId { get; set; }
    }
}