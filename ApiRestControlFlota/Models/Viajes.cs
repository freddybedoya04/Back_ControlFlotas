using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiRestControlFlota.Models
{
    public class Viajes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VIA_Id { get; set; }
        public DateTime VIA_FechaInicio { get; set; }
        [Required]
        [StringLength(250)]
        public string VIA_Empresa { get; set; }
        [Required]
        [StringLength(250)]
        public string VIA_Manifiesto { get; set; }
        public int CON_CedulaConductor{ get; set; }
        [Required]
        [StringLength(250)]
        public string VEI_CodigoVehiculo { get; set; }
        public string VIA_Origen { get; set; }
        public string VIA_Destino { get; set; }
        public int VIA_KmRecorridos { get; set; }
        public double? VIA_PagoConductor { get; set; }
        public double? VIA_PagoCombustible { get; set; }
        public double? VIA_PagoPeajes{ get; set; }
        public double? VIA_PagoOtros { get; set; }
        public string VIA_DetallesViaje { get; set; }
        public double? VIA_ValorViaje { get; set; }
        public double? VIA_Utilidades { get; set; }
        public bool? VIA_Habilitado{ get; set; }
        public DateTime? VIA_TimeStand { get; set; }
        public bool? VIA_Peso { get; set; }

    }
}
