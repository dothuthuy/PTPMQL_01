using System.ComponentModel.DataAnnotations;
using System.Data;

namespace MvcMovie.Models;

public  class HeThongPhanPhoi
{
    [Key]
    public string MaHTPP {get; set;}
    public string? TenHTPP {get; set;}
    public ICollection<DaiLy> DaiLy {get;set;}


    }