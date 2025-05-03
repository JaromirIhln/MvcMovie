using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models;

public class MovieGenreViewModel
{
    /// <summary>
    /// A list of movies.
    /// </summary>
    public List<Movie>? Movies { get; set; }
    /// <summary>
    /// A SelectList of genres.
    /// </summary>
    public SelectList? Genres { get; set; }
    /// <summary>
    /// A string representing the selected genre.
    /// </summary>
    public string? MovieGenre { get; set; }
    /// <summary>
    /// A string representing the search string.
    /// </summary>
    public string? SearchString { get; set; }
}