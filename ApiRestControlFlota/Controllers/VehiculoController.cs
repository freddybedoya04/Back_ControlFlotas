using ApiRestControlFlota.Catalogos;
using ApiRestControlFlota.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiRestControlFlota.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiculoController : Controller
    {
        private readonly MyDbContext myDbContext;
        public VehiculoController(MyDbContext context) { 
            myDbContext = context;
        }
        // GET: VehiculoController
        [HttpGet]
        [Route("ListarVehiculos")]
        public async Task<IActionResult> ListarVehiculos()
        {
            CatalogoVehiculo catalogo = new CatalogoVehiculo(myDbContext);
            
            return Ok(catalogo.ListarVehiculos());
        }

        [HttpPost]
        [Route("AgregarVehiculo")]
        public async Task<IActionResult> AgregarVehiculo([FromBody] Vehiculo vehiculo)
        {
            CatalogoVehiculo catalogo = new CatalogoVehiculo(myDbContext);
            try
            {
                catalogo.AgregarVehiculo(vehiculo);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            return Ok();
        }

        [HttpDelete]
        [Route("EliminarVehiculo/{VEI_Id:int}")]
        public async Task<IActionResult> EliminarVehiculo(int VEI_Id )
        {
            CatalogoVehiculo catalogo = new CatalogoVehiculo(myDbContext);
            try
            {
                catalogo.EliminarVehiculo(VEI_Id);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            return Ok();
        }
    }
}
