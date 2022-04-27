using doonamis_technical_test.Models;
using doonamis_technical_test.Services;
using Microsoft.AspNetCore.Mvc;

namespace doonamis_technical_test.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class RoverController : ControllerBase
{
    MarsModel _mars = Globals.Mars;

    private readonly ILogger<RoverController> _logger;

    public RoverController(ILogger<RoverController> logger)
    {
        _logger = logger;
    }

    public ActionResult GetRover()
    {
        try
        {
            MarsService s = new(_mars);
            HashSet<RoverModel> rover = s.GetRover();
            return rover is not null ? Ok(rover) : NotFound();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    public ActionResult GetRoverByName([FromQuery] string name)
    {
        try
        {
            MarsService s = new(_mars);
            RoverModel? rover = s.GetRoverByName(name);
            return rover is not null ? Ok(rover) : NotFound();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    public ActionResult GetRoversPosition()
    {
        try
        {
            MarsService s = new(_mars);
            HashSet<Coordinates> coordinates = s.GetRoversPosition();
            return coordinates.Count > 0 ? Ok(coordinates) : NotFound();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    public ActionResult GetOrientation([FromQuery] string name)
    {
        try
        {
            MarsService s = new(_mars);
            RoverModel? rover = s.GetRoverByName(name);
            if (rover is not null)
            {
                OrientationEnum orientation = rover.GetOrientation();
                return Ok(orientation);
            }
            return NotFound();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    public ActionResult ChangeOrientation([FromQuery] string name, OrientationEnum orientation)
    {
        try
        {
            MarsService s = new(_mars);
            RoverModel? rover = s.GetRoverByName(name);
            if (rover is not null)
            {
                rover.ChangeOrientation(orientation);
                return Ok(rover);
            }
            return NotFound();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    public ActionResult MoveForward([FromQuery] string name)
    {
        try
        {
            MarsService s = new(_mars);
            RoverModel? rover = s.GetRoverByName(name);
            if (rover is not null)
            {
                RoverModel roverModel = rover.MoveForward();
                return Ok(roverModel);
            }
            return NotFound();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    public ActionResult HandleRoverMovement([FromQuery] string name, string movements)
    {
        try
        {
            MarsService s = new(_mars);
            RoverModel? rover = s.GetRoverByName(name);
            if (rover is not null)
            {
                List<char> movs = movements.ToUpper().ToList();
                RoverMovements roverMovements = rover.HandleMovement(movs);
                return Ok(roverMovements);
            }
            return NotFound();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    public ActionResult GetCoordinates([FromQuery] string name)
    {
        try
        {
            MarsService s = new(_mars);
            RoverModel? rover = s.GetRoverByName(name);
            if (rover is not null)
            {
                rover.GetCoordinates();
                return Ok(rover);
            }
            return NotFound();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    public ActionResult ResetCoordinates([FromQuery] string name)
    {
        try
        {
            MarsService s = new(_mars);
            RoverModel? rover = s.GetRoverByName(name);
            if (rover is not null)
            {
                rover.ResetCoordinates();
                return Ok(rover);
            }
            return NotFound();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}

