using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{

    public int MovieId { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Title { get; set; }

    [Display(Name = "Release Date"), DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Range(1, 100), DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; } = 0.00M;

    [Required]
    public string? Genre { get; set; }

    [Required]
    public string? Rating { get; set; }

    [Display(Name = "Image File Name")]
    public string? ImageFileName { get; set; }

}