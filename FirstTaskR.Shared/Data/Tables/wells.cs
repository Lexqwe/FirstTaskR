using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstTaskR.Shared.Data.Tables
{
    [Table("wells")]
    public class Well
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int well { get; set; }

        [ForeignKey("well")]
        public virtual Object fk_well { get; set; }

        [Required]
        public int ngdu { get; set; }

        [ForeignKey("ngdu")]
        public virtual Object fk_ngdu { get; set; }

        [Required]
        public int cdng { get; set; }

        [ForeignKey("cdng")]
        public virtual Object fk_cdng { get; set; }

        [Required]
        public int kust { get; set; }

        [ForeignKey("kust")]
        public virtual Object fk_kust { get; set; }

        [Required]
        public int mest { get; set; }

        [ForeignKey("mest")]
        public virtual Object fk_mest { get; set; }

    }

}

