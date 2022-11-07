using static UnitConversion.ConversionType.Length;

namespace UnitConversion.ConversionType;
public interface IUnit
{
    Type? Validate(string? fromUnit, string? toUnit);
}
