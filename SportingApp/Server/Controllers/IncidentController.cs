using Microsoft.AspNetCore.Mvc;
using SportingApp.Data.Domain;
using SportingApp.Shared.Interfaces;

namespace SportingApp.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IncidentController : ControllerBase
    {
        private readonly IIncidentService _incidentService;

        public IncidentController(IIncidentService incidentService)
        {
            _incidentService = incidentService;
        }
        [HttpGet(Name = "getincidents")]
        public async Task<ActionResult<List<Incident>>> GetIncidents()
        {
            var incidents = await _incidentService.GetIncidents();
            return Ok(incidents);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Incident>> GetIncidentById(long id)
        {
            var incident = await _incidentService.GetIncidentById(id);
            if (incident == null)
            {
                return NotFound("Sorry, no Incident here. :/");
            }
            return Ok(incident);
        }

        [HttpPost(Name ="createincident")]
        public async Task<ActionResult<List<Incident>>> CreateIncident([FromBody] Incident model)
        {
            var incidents = await _incidentService.SaveIncident(model.Id,model.Title,model.Description,model.DateOpened,model.DateClosed,model.CustomerId,model.ProductId,model.TechnicianId);
            return Ok(incidents);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Incident>>> DeleteIncident(int id)
        {

            var incidents = await _incidentService.DeleteIncident(id);
            return Ok(incidents);
        }
       
    }
}
