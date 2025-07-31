using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstTaskR.Shared.Data.Tables
{
    [Table("objects")]
    public class Object
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [MaxLength(42)]
        public string name { get; set; }

        [Required]
        public int type { get; set; }
        [ForeignKey("type")]
        public virtual ObjectType fk_type { get; set; }
    }
}
