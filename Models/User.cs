using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CV
{
    [Table("users")]
    public class User
    {
        [Key]
        [Column(TypeName = "INT")]
        public int user_id {get; set;}

        [Column(TypeName = "NVARCHAR")]
        public string user_name {get; set;}

        [Column(TypeName = "NVARCHAR")]
        public string user_guid {get; set;}
        
        [Column(TypeName = "NVARCHAR")]
        public string user_login_name {get; set;}

        [Column(TypeName = "NVARCHAR")]
        public string user_email {get; set;}
        
        [Column(TypeName = "BINARY")]
        public byte[] user_password {get; }

        [Column(TypeName = "NVARCHAR")]
        public string user_first_name {get; set;}

        [Column(TypeName = "NVARCHAR")]
        public string user_last_name {get; set;}

    }

}