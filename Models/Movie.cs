
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Models;

public class Movie
{
  public int Id { get; set; }

  [StringLength(60, MinimumLength = 3)]
  [Required]
  public string Title { get; set; } = string.Empty;

  [DisplayName("Release Date")]
  [DataType(DataType.Date)]
  public DateTime ReleaseDate { get; set; }

  [RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$")]
  [Required]
  [StringLength(30)]
  public string Genre { get; set; } = string.Empty;

  // [Precision(18, 2)]
  [Range(1, 100)]
  [DataType(DataType.Currency)]
  [Column(TypeName = "decimal(18, 2)")]
  public decimal Price { get; set; }

  [Range(1, 5)]
  [Required]
  public int Rating { get; set; } = 0;
}