using System.ComponentModel.DataAnnotations;
using System.Data;

namespace MvcMovie.Models;

public  class Movie
{
    [Key]
    public int Id {get; set;}
    public string? Title {get; set;}
    public DateTime ReleaseData {get;set;}
    public string? Genre {get;set;}
    public decimal Price {get; set;}
    }
