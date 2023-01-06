using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV.Models;

public class Image
{
    [Key]
    [Column(TypeName = "INT")]
    public int id { get; set; }

    [Column(TypeName = "INT")]
    public int size { get; set; }

    [Column(TypeName = "NVARCHAR")]
    public string? title { get; set; }

    [Column(TypeName = "DATETIME")]
    DateTime date_time { get; set; }
}
