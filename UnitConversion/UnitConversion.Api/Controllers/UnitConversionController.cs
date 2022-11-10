using Microsoft.AspNetCore.Mvc;
using UnitConversion.Interfaces;

namespace UnitConversion.Api.Controllers;
[ApiController]
[Route("[controller]")]
public class UnitConversionController : ControllerBase
{
    private readonly ILogger<UnitConversionController> _logger;
    private readonly IConversion _conversion;

    public UnitConversionController(ILogger<UnitConversionController> logger, IConversion conversion)
    {
        _conversion = conversion;
        _logger = logger;
    }

    [HttpPost(Name = "CalculateConversion")]
    public IResult CalculateConversion(string unitFrom, string unitTo)
    {
        var result = _conversion.CalculateConversion(unitFrom, unitTo);
        return Results.Ok(result);
    }
}
