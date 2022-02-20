using Microsoft.AspNetCore.Mvc;
using SportingApp.Data.Domain;
using SportingApp.Shared.Interfaces;

namespace SportingApp.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {

        private readonly IRegistrationService _registrationService;

        public RegistrationController(IRegistrationService registrationService)
        {
            _registrationService = registrationService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Registration>>> GetRegistrations()
        {
            var registrations = await _registrationService.GetRegistrations();
            return Ok(registrations);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Registration>> GetRegistrationById(long id)
        {
            var registration = await _registrationService.GetRegistrationById(id);
            if (registration == null)
            {
                return NotFound("Sorry, no Incident here. :/");
            }
            return Ok(registration);
        }

        [HttpPost(Name = "createregistration")]
        public async Task<ActionResult<List<Registration>>> CreateRegistration([FromBody] Registration model)
        {
            var registrations = await _registrationService.SaveRegistration(model.Id,model.CustomerId,model.ProductId);
            return Ok(registrations);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Registration>>> DeleteRegistration(int id)
        {

            var registrations = await _registrationService.DeleteRegistration(id);
            return Ok(registrations);
        }
    }
}
