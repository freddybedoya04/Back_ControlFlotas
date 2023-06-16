using ApiRestControlFlota.ClasesAuxiliares;
using ApiRestControlFlota.Models;

namespace ApiRestControlFlota.Catalogos
{
    public class CatalogoViajes
    {
        private readonly MyDbContext myDbContext;

        public CatalogoViajes(MyDbContext context)
        {
            myDbContext = context;
        }

        public List<Viajes> ListarViajesPorFecha(DTOBusqueda Filtro)
        {
            try
            {
                
                List<Viajes> Viajes = myDbContext.Viajes.Where(x => x.VIA_Habilitado == true && 
                x.VIA_FechaInicio>= Filtro.FechaInicio && x.VIA_FechaInicio<=Filtro.FechaFin).ToList();

                return Viajes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Viajes> ListarViajesPorVehiculo(DTOBusqueda Filtro)
        {
            try
            {

                List<Viajes> Viajes = myDbContext.Viajes.Where(x => x.VIA_Habilitado == true &&
                x.VIA_FechaInicio >= Filtro.FechaInicio && x.VIA_FechaInicio <= Filtro.FechaFin &&
                x.VEI_CodigoVehiculo==Filtro.CodigoVehiculo).ToList();

                return Viajes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AgregarViaje(Viajes Viaje)
        {
            try
            {
                myDbContext.Viajes.Add(Viaje);
                myDbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EliminarViaje(int VIA_Id)
        {
            try
            {
                Viajes viaje = myDbContext.Viajes.Where(x => x.VIA_Id == VIA_Id).FirstOrDefault();
                if (viaje != null)
                {
                    viaje.VIA_Habilitado = false;
                    myDbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
