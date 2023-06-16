using ApiRestControlFlota.Catalogos;
using ApiRestControlFlota.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiRestControlFlota.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConductorController : Controller
    {
        private readonly MyDbContext myDbContext;
        public ConductorController(MyDbContext context)
        {
            myDbContext = context;
        }
        [HttpGet]
        [Route("ListarConductores")]
        public  async Task<IActionResult> ListarConductores()
        {
            CatalogoConductor catalogo = new CatalogoConductor(myDbContext);

            return Ok(catalogo.ListarConductores());
        }

        [HttpPost]
        [Route("AgregarConductor")]
        public  async Task<IActionResult> AgregarConductor([FromBody] Conductor conductor)
        {
            CatalogoConductor catalogo = new CatalogoConductor(myDbContext);
            try
            {
                catalogo.AgregarConductor(conductor);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            return Ok();
        }

        [HttpDelete]
        [Route("EliminarConductor/{CON_Id:int}")]
        public async Task<IActionResult> EliminarConductor(int CON_Id)
        {
            CatalogoConductor catalogo = new CatalogoConductor(myDbContext);
            try
            {
                catalogo.EliminarConductor(CON_Id);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            return Ok();
        }
    }
}
