﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        //Data anotation
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]

        public DateTime RealeaseDate { get; set; }

        public string? Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set;}

        public string? Rating { get; set; }
   
    }
}
