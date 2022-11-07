using static UnitConversion.ConversionType.Length;
using System.Collections.Generic;
using UnitConversion.Model;

namespace UnitConversion.ConversionType;
public class Length : Unit, IUnit
{
    public Length(string[]? searchKeyWords) : base(searchKeyWords)
    {
    }

    public Type? Validate(string? fromUnit, string? toUnit)
    {
        if (fromUnit == null || toUnit == null)
            throw new ArgumentNullException(nameof(fromUnit) + " " + nameof(toUnit));

        var isFromUnitValid = _searchKeyWords?.Contains(fromUnit);
        var isToUnitValid = _searchKeyWords?.Contains(toUnit);
        if (isFromUnitValid.HasValue && isFromUnitValid.Value &&
            isToUnitValid.HasValue && isToUnitValid.Value)
            return typeof(Length);

        return null;
    } 

    public double ConvertFromTo(int value, UnitMetrics from, UnitMetrics to)
    {
        return (from, to) switch
        {
            (UnitMetrics.Meter, UnitMetrics.Inch) => value * 39.37,
            (UnitMetrics.Meter, UnitMetrics.Foot) => value * 3.28,
            (UnitMetrics.Inch, UnitMetrics.Foot) => value * 0.083,
            (UnitMetrics.Inch, UnitMetrics.Meter) => value * 0.0254,
            (UnitMetrics.Foot, UnitMetrics.Meter) => value * 0.3048,
            (UnitMetrics.Foot, UnitMetrics.Inch) => value * 12,
            _ => throw new NotImplementedException(),
        };
    }
}
