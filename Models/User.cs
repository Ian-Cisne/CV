using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CV.Models;
[Table("users")]
public class User
{
    [Key]
    [Column(TypeName = "INT")]
    public int id {get; set;}

    [Required]
    [Column(TypeName = "NVARCHAR")]
    public string name {get; set;}

    [Required]
    [Column(TypeName = "NVARCHAR")]
    public string guid {get; set;}
    
    [Required]
    [Column(TypeName = "NVARCHAR")]
    public string login_name {get; set;}

    [Required]
    [Column(TypeName = "NVARCHAR")]
    public string email {get; set;}
    
    [Required]
    [Column(TypeName = "BINARY")]
    public byte[] password {get; }

    [Required]
    [Column(TypeName = "NVARCHAR")]
    public string first_name {get; set;}

    [Required]
    [Column(TypeName = "NVARCHAR")]
    public string last_name {get; set;}

}

