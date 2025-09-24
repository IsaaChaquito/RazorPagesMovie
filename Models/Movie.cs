
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Models;

public class Movie
{
  public int Id { get; set; }
  public string? Title { get; set; }
  
  [DisplayName("Release Date")]
  [DataType(DataType.Date)]
  public DateTime ReleaseDate { get; set; }
  public string? Genre { get; set; }

  // [Precision(18, 2)]
  [Column(TypeName = "decimal(18, 2)")]
  public decimal Price { get; set; }
}