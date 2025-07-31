using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstTaskR.Shared.Data.Tables
{
    [Table("object_types")]
    public class ObjectType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }


        [Required]
        [MaxLength(42)]
        public string name { get; set; }
    }
}
