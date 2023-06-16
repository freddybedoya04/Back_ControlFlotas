using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiRestControlFlota.Models
{
    public class Conductor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CON_Id { get; set; }
        [Required]
        public int CON_CedulaConductor { get; set; }
        [Required]
        [StringLength(250)]
        public string CON_NombresConductor { get; set; }
        [Required]
        [StringLength(250)]
        public string CON_ApellidosConductor { get; set; }

        public bool CON_Habilitado { get; set; }
        public DateTime? CON_FechaNacimiento { get; set; }
        public string CON_TipoLicencia { get; set; }
        public DateTime? CON_FechaIngreso { get; set; }
        public DateTime? CON_TimeStand { get; set; }
    }
}
