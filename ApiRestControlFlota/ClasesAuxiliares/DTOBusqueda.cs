namespace ApiRestControlFlota.ClasesAuxiliares
{
    public class DTOBusqueda
    {
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string CodigoVehiculo { get; set; }

        public string Conductor { get; set; }
    }
}
