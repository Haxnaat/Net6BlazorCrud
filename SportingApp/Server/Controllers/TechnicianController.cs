using Microsoft.AspNetCore.Mvc;
using SportingApp.Data.Domain;
using SportingApp.Shared.Interfaces;

namespace SportingApp.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TechnicianController : ControllerBase
    {
        private readonly ITechnicianService  _technicianService;

        public TechnicianController(ITechnicianService technicianService)
        {
            _technicianService = technicianService;
        }
        [HttpGet(Name ="gettechnicians")]
        public async Task<ActionResult<List<Technician>>> GetTechnicians()
        {
            var technicians = await _technicianService.GetTechnicians();
            return Ok(technicians);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Technician>> GetTechnicianById(long id)
        {
            var technician = await _technicianService.GetTechnicianById(id);
            if (technician == null)
            {
                return NotFound("Sorry, no Technician here. :/");
            }
            return Ok(technician);
        }

        [HttpPost(Name ="createtechnician")]
        public async Task<ActionResult<List<Technician>>> CreateTechnician([FromBody] Technician model)
        {
            var technicians = await _technicianService.SaveTechnician(model.Id, model.Email, model.FirstName, model.LastName, model.Phone);
            return Ok(technicians);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Technician>>> DeleteTechnician(int id)
        {

            var customers = await _technicianService.DeleteTechnician(id);
            return Ok(customers);
        }
    }
}
