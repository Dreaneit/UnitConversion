using UnitConversion.Model;

namespace UnitConversion.ConversionType;

public interface IBaseUnit
{
    FromToConversionModel? GetConversionUnits(string? fromUnit, string? toUnit);
}