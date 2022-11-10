using UnitConversion.Interfaces;
using UnitConversion.Model;

namespace UnitConversion.ConversionType;
public class Length : IUnit
{
    public Length() : base()
    {
    }

    public decimal ConvertFromTo(decimal value, FromToConversionModel? conversionModel)
    {
        return (conversionModel?.From, conversionModel?.To) switch
        {
            (UnitMetrics.Meter, UnitMetrics.Inch) => value * 39.37m,
            (UnitMetrics.Meter, UnitMetrics.Feet) => value * 3.28m,
            (UnitMetrics.Inch, UnitMetrics.Feet) => value * 0.083m,
            (UnitMetrics.Inch, UnitMetrics.Meter) => value * 0.025m,
            (UnitMetrics.Feet, UnitMetrics.Meter) => value * 0.304m,
            (UnitMetrics.Feet, UnitMetrics.Inch) => value * 12m,
            _ => throw new NotImplementedException(),
        };
    }
}
