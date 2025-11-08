using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 3)] //validation rule
    [Required] //validation rule
    public string? Title { get; set; }

    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Range(1, 100)] //validation rule
    [DataType(DataType.Currency)] //validation rule
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }    

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")] //validation rule
    [Required] //validation rule
    [StringLength(30)] //validation rule
    public string? Genre { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")] //validation rule
    [StringLength(5)] //validation rule
    [Required] //validation rule
    public string? Rating { get; set; }
}