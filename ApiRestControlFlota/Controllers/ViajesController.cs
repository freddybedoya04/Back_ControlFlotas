using ApiRestControlFlota.Catalogos;
using ApiRestControlFlota.ClasesAuxiliares;
using ApiRestControlFlota.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiRestControlFlota.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ViajesController : Controller
    {
        private readonly MyDbContext myDbContext;
        public ViajesController(MyDbContext context)
        {
            myDbContext = context;
        }
        // GET: VehiculoController
        [HttpPost]
        [Route("ListarViajesPorFecha")]
        public async Task<IActionResult> ListarViajesPorFecha([FromBody]DTOBusqueda Filtro)
        {
            CatalogoViajes catalogo = new CatalogoViajes(myDbContext);

            return Ok(catalogo.ListarViajesPorFecha(Filtro));
        }
        [HttpPost]
        [Route("ListarViajesPorVehiculo")]
        public async Task<IActionResult> ListarViajesPorVehiculo([FromBody]DTOBusqueda Filtro)
        {
            CatalogoViajes catalogo = new CatalogoViajes(myDbContext);

            return Ok(catalogo.ListarViajesPorVehiculo(Filtro));
        }
        [HttpPost]
        [Route("ListarViajesPorConductor")]
        public async Task<IActionResult> ListarViajesPorConductor([FromBody] DTOBusqueda Filtro)
        {
            CatalogoViajes catalogo = new CatalogoViajes(myDbContext);

            return Ok(catalogo.ListarViajesPorConductor(Filtro));
        }
        [HttpPost]
        [Route("AgregarViaje")]
        public async Task<IActionResult> AgregarViaje([FromBody] Viajes Viaje)
        {
            CatalogoViajes catalogo = new CatalogoViajes(myDbContext);
            try
            {
                catalogo.AgregarViaje(Viaje);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            return Ok();
        }

        [HttpDelete]
        [Route("EliminarViaje/{VIA_Id:int}")]
        public async Task<IActionResult> EliminarViaje(int VIA_Id)
        {
            CatalogoViajes catalogo = new CatalogoViajes(myDbContext);
            try
            {
                catalogo.EliminarViaje(VIA_Id);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            return Ok();
        }
    }
}
