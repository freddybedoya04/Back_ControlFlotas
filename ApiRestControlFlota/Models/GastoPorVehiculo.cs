using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiRestControlFlota.Models
{
    public class GastoPorVehiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GPV_Id { get; set; }
        public string VEI_CodigoVehiculo { get; set; }

        public double GPV_Valor{ get; set; }
        public string GPV_Detalle { get; set; }
        public bool GPV_Habilitado { get; set; }
        public DateTime? GPV_FechaIngreso { get; set; }
        public DateTime? GPV_TimeStand { get; set; }

    }
}
