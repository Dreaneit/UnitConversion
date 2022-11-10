using UnitConversion.Model;

namespace UnitConversion.Interfaces;
public interface IUnit
{
    decimal ConvertFromTo(decimal value, FromToConversionModel? fromToConversionModel);
}
