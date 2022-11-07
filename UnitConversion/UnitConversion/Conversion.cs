using UnitConversion.ConversionType;
using UnitConversion.Model;

namespace UnitConversion;
public class Conversion
{
    private ISIComparer _siComparer;
    private Length _LengthConvertor;
    private IUnit _unit;

    public Conversion(ISIComparer sIComparer, IUnit unit)
    {
        _LengthConvertor = new Length(new string[] { "meter", "inch", "feet", "meters", "inches", "feets" });
        _siComparer = sIComparer;
        _unit = unit;
    }

    public string CalculateConversion(string fromUnitWithValue, string toUnit)
    {
        InputUnit inputUnit = HandleInputs(fromUnitWithValue, toUnit);

        var keke = _unit.Validate(inputUnit.FromUnit, inputUnit.ToUnit);
        var valueForConversion = _siComparer.GetValueOfNumberAndPrefixSI(inputUnit.Value, inputUnit.FromUnit);

        return "1 meter";
    }

    private InputUnit HandleInputs(string fromInput, string toInput)
    {
        string stringUnitValue = new(fromInput.Where(Char.IsDigit).ToArray());
        int.TryParse(stringUnitValue, out int unitValue);

        string fromUnit = new(fromInput.Where(Char.IsLetter).ToArray());
        var siPrefix = _siComparer.GetPrefix(fromUnit);
        string toUnit = new(toInput.Where(Char.IsLetter).ToArray());

        return new InputUnit
        {
            Value = unitValue,
            UnitPrefix = siPrefix,
            FromUnit = _siComparer.RemovePrefix(fromUnit, siPrefix.PrefixName),
            ToUnit = toUnit
        };
    }
}
