using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstTaskR.Shared.Data.Tables
{
    [Table("well_day_histories")]
    [PrimaryKey(nameof(well), nameof(date_fact))]
    public class WellDayHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int well { get; set; }

        [ForeignKey("well")]
        public virtual Object fk_well_p { get; set; }

        [Required]
        public DateOnly date_fact { get; set; }

        [Required]
        [Range(-99,99)]
        public short debit { get; set; }

        [Required]
        [Precision(5, 2)]
        [Column(TypeName = "REAL")]
        public float ee_consume { get; set; }

        [Required]
        [Precision(4, 3)]
        [Column(TypeName = "REAL")]
        public float expenses { get; set; }

        [Required]
        [Range(-99, 99)]
        public short pump_operating { get; set; }
    }
}
