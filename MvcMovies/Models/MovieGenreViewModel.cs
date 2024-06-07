using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovies.Models
{
    //MODELO QUE ME SIRVE PARA UNA VISTA
    public class MovieGenreViewModel
    {
        public List<Movie>? Movies { get; set; }
        public SelectList? Genre { get; set; }
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }


    }
}
