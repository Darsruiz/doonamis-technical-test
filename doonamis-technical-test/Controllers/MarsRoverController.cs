using doonamis_technical_test.Models;
using doonamis_technical_test.Services;
using Microsoft.AspNetCore.Mvc;

namespace doonamis_technical_test.Controllers;

[ApiController]
[Route("[controller]")]
public class MarsRoverController : ControllerBase
{
    private Mars _mars;

    private readonly ILogger<MarsRoverController> _logger;

    public MarsRoverController(ILogger<MarsRoverController> logger)
    {
        _logger = logger;
    }

    #region Rover

    [HttpGet]
    public ActionResult GetRover()
    {
        MarsService s = new(_mars);
        HashSet<RoverModel> rover = s.GetRover();
        if (rover is not null)
        {
            return Ok(rover);
        }
        return NotFound();
    }

    [HttpPost]
    public ActionResult GetRover(string name)
    {
        MarsService s = new(_mars);
        RoverModel rover = s.GetRoverByName(name);
        if (rover is not null)
        {
            return Ok(rover);
        }
        return NotFound();
    }

    public ActionResult GetRoversPosition() {
        MarsService s = new(_mars);
        HashSet<Coordinates>? coordinates = s.GetRoversPosition();
        if (coordinates is not null) {
            return Ok(coordinates);
        }
        return NotFound();
    }

    public ActionResult GetOrientation(string name) {
        MarsService s = new(_mars);
        RoverModel rover = s.GetRoverByName(name);
        if (rover is not null)
        {
            OrientationEnum orientation = rover.GetOrientation();
            return Ok(orientation);
        }
        return NotFound();
    }

    public ActionResult ChangeOrientation(string name, OrientationEnum orientationEnum) {
        MarsService s = new(_mars);
        RoverModel rover = s.GetRoverByName(name);
        if (rover is not null)
        {
            rover.ChangeOrientation(orientationEnum);
            return Ok(rover);
        }
        return NotFound();

    }

    public ActionResult MoveForward(string name) {
        MarsService s = new(_mars);
        RoverModel rover = s.GetRoverByName(name);
        if (rover is not null)
        {
            rover.MoveForward();
            return Ok(rover);
        }
        return NotFound();
    }
    public ActionResult GetCoordinates(string name) {
        MarsService s = new(_mars);
        RoverModel rover = s.GetRoverByName(name);
        if (rover is not null)
        {
            rover.GetCoordinates();
            return Ok(rover);
        }
        return NotFound();
    }
    public ActionResult ResetCoordinates(string name) {
        MarsService s = new(_mars);
        RoverModel rover = s.GetRoverByName(name);
        if (rover is not null)
        {
            rover.ResetCoordinates();
            return Ok(rover);
        }
        return NotFound();
    }
    #endregion
    #region Mars

    [HttpGet]
    public ActionResult GetMars()
    {
        MarsService s = new(_mars);
        MarsModel model = s.GetMars();
        if (model is not null)
        {
            return Ok(model);
        }
        return NotFound();
    }
    [HttpGet]
    public ActionResult GetBoundaries()
    {
        MarsService s = new(_mars);
        var coordinates = s.GetBoundaries();
        if (coordinates is not null)
        {
            return Ok(coordinates);
        }
        return NotFound();
    }
    [HttpGet]
    public ActionResult Get3DBoundaries()
    {
        MarsService s = new(_mars);
        HashSet<Coordinates> coordinates = s.Get3DBoundaries();
        if (coordinates is not null)
        {
            return Ok(coordinates);
        }
        return NotFound();
    }

    [HttpGet]
    public ActionResult SetMarsBoundaries(double x, double y)
    {
        MarsService s = new(_mars);
        MarsModel mars = s.SetMarsBoundaries(x, y);
        if (mars is not null)
        {
            return Ok(mars);
        }
        return NotFound();
    }
    [HttpGet]
    public ActionResult SetMarsBoundaries(double x, double y, double z)
    {
        MarsService s = new(_mars);
        MarsModel mars = s.SetMarsBoundaries(x, y, z);
        if (mars is not null)
        {
            return Ok(mars);
        }
        return NotFound();
    }
    [HttpGet]
    public ActionResult SetMarsBoundaries(double x, double y, double z, double x2, double y2, double z2)
    {
        MarsService s = new(_mars);
        Coordinates coordinate1 = new(x, y, z);
        Coordinates coordinate2 = new(x2, y2, z2);

        MarsModel mars = s.SetMarsBoundaries(coordinate1, coordinate2);
        if (mars is not null)
        {
            return Ok(mars);
        }
        return NotFound();
    }
    #endregion
}

