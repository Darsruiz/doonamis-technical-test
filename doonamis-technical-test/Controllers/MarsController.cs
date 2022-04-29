using doonamis_technical_test.Models;
using doonamis_technical_test.Services;
using Microsoft.AspNetCore.Mvc;

namespace doonamis_technical_test.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class MarsController : ControllerBase
{
    private readonly ILogger<MarsController> _logger;

    public MarsController(ILogger<MarsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public ActionResult GetMars()
    {
        try
        {
            MarsService s = new();
            MarsModel model = s.GetMars();
            return Ok(model);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    [HttpGet]
    public ActionResult GetBoundaries()
    {
        try
        {
            MarsService s = new();
            var coordinates = s.GetBoundaries();
            return coordinates is not null ? Ok(coordinates) : NotFound();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    [HttpGet]
    public ActionResult Get3DBoundaries()
    {
        try
        {
            MarsService s = new();
            Coordinates coordinates = s.Get3DBoundaries();
            return coordinates is not null ? Ok(coordinates) : NotFound();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public ActionResult SetMarsBoundaries([FromQuery] double x, double y, double z = 0)
    {
        try
        {
            MarsService s = new();
            Coordinates coordinate = new(x, y, z);
            MarsModel mars = s.SetMarsBoundaries(coordinate);
            return mars is not null ? Ok(mars) : NotFound();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    [HttpGet]
    public ActionResult SetMars3DBoundaries([FromQuery] double x, double y, double z)
    {
        try
        {
            MarsService s = new();
            Coordinates coordinate = new(x, y, z);

            MarsModel mars = s.SetMars3DBoundaries(coordinate);
            return mars is not null ? Ok(mars) : NotFound();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    public ActionResult ResetMars()
    {
        try
        {
            MarsService s = new();
            MarsModel marsModel = s.ResetMars();
            return Ok(marsModel);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}

