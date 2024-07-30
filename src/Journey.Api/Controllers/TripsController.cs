using Journey.Application.UseCases.Trips.GetAll;
using Journey.Application.UseCases.Trips.Register;
using Journey.Communication.Requests;
using Journey.Exception.ExceptionsBase;
using Microsoft.AspNetCore.Mvc;

namespace Journey.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TripsController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterTripJson resquest)
    {
        try
        {
            var useCase = new RegisterTripUseCase();
            var response = useCase.Execute(resquest);

            return Created(string.Empty, response);
        }
        catch(JourneyException ex)
        {
            return BadRequest(ex.Message);
        }
        catch 
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Erro desconehcido");
        }
    }


    [HttpGet]
    public IActionResult GetAll()
    {
        var userCase = new GetAllTripUseCase();
        var response = userCase.Execute();
        return Ok(response);
    }
}
