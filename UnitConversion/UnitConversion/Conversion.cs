using UnitConversion.ConversionType;
using UnitConversion.Interfaces;
using UnitConversion.Model;

namespace UnitConversion;
public class Conversion : IConversion
{
    private ISIPrefixes _siPrefixes;
    private IBaseUnit _unit;

    public Conversion()
    {
        _siPrefixes = new SIPrefixes();
        _unit = new Unit(new List<MetricsType>()
        {
            new MetricsType(typeof(Length), new List<MetricsSearchKeywords>()
            {
                new MetricsSearchKeywords(UnitMetrics.Meter, new string[] { "meter", "meters" }),
                new MetricsSearchKeywords(UnitMetrics.Inch, new string[] { "inch", "inches" }),
                new MetricsSearchKeywords(UnitMetrics.Feet, new string[] { "feet", "feets" })
            })
        });
    }

    public string CalculateConversion(string fromUnitWithValue, string toUnit)
    {
        InputUnit inputUnit = new InputUnit(fromUnitWithValue, toUnit, _siPrefixes);

        var fromToConversionModel = _unit.GetConversionUnits(inputUnit.FromUnit, inputUnit.ToUnit);

        var result = fromToConversionModel?.ConversionInstance?.ConvertFromTo(inputUnit.Value, fromToConversionModel);

        return $"{result} {inputUnit.ToUnit}";
    }
}
