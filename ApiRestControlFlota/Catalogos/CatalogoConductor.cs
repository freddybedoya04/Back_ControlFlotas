using ApiRestControlFlota.Models;

namespace ApiRestControlFlota.Catalogos
{
    public class CatalogoConductor
    {
        private readonly MyDbContext myDbContext;

        public CatalogoConductor(MyDbContext context)
        {
            myDbContext = context;
        }

        public List<Conductor> ListarConductores()
        {
            try
            {
                List<Conductor> Conductores = myDbContext.Conductores.Where(x => x.CON_Habilitado == true).ToList();
                return Conductores;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AgregarConductor( Conductor conductor)
        {
            try
            {
                myDbContext.Conductores.Add( conductor );
                myDbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EliminarConductor(int CON_Id)
        {
            try
            {
                Conductor conductor= myDbContext.Conductores.Where(x=>x.CON_Id==CON_Id).FirstOrDefault();
                if ( conductor != null )
                {
                    conductor.CON_Habilitado = false;
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
