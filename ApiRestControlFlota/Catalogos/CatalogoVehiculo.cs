using ApiRestControlFlota.Models;

namespace ApiRestControlFlota.Catalogos
{
    public class CatalogoVehiculo
    {
        private readonly MyDbContext myDbContext;

        public CatalogoVehiculo(MyDbContext context)
        {
            myDbContext = context;
        }

        public List<Vehiculo> ListarVehiculos()
        {
            try
            {
                List<Vehiculo> Vehiculos = myDbContext.Vehiculos.Where(x => x.VEI_Habilitado == true).ToList();
                return Vehiculos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                myDbContext.Vehiculos.Add(vehiculo);
                myDbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EliminarVehiculo(int VEI_Id)
        {
            try
            {
                Vehiculo vehiculo= myDbContext.Vehiculos.Where(x=>x.VEI_Id == VEI_Id).FirstOrDefault();
                if(vehiculo != null)
                {
                    vehiculo.VEI_Habilitado = false;
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
