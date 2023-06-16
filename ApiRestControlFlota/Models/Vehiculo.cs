using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiRestControlFlota.Models
{
    public class Vehiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VEI_Id { get; set; }
        [Required]
        [StringLength(250)]
        public string VEI_CodigoVehiculo { get; set; }
        [Required]
        [StringLength(250)]
        public string VEI_PlacaVehiculo { get; set; }

        public bool VEI_Habilitado { get; set; }
        public string VEI_Descripcion { get; set; }
        public string VEI_Modelo { get; set; }
        public int? VEI_PesoLimite { get; set; }
        public int? VEI_KmInicial { get; set; }
        public DateTime? VEI_FechaIngreso { get; set; }
        public DateTime? VEI_TimeStand { get; set; }
    }
}
