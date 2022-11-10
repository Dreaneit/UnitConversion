using UnitConversion.Interfaces;

namespace UnitConversion.Model;

public class InputUnit : IInputUnit
{
    private ISIPrefixes _siComparer;
    private readonly string _fromUnit;
    private readonly string _toUnit;

    public InputUnit(string fromUnit, string toUnit, ISIPrefixes siComparer)
    {
        _fromUnit = fromUnit;
        _toUnit = toUnit;
        _siComparer = siComparer;
        this.HandleInputs();
    }

    public decimal Value { get; set; }
    public SIPrefix? UnitPrefix { get; set; }
    public string? FromUnit { get; set; }
    public string? ToUnit { get; set; }

    private void HandleInputs()
    {
        string stringUnitValue = new(_fromUnit.Where(Char.IsDigit).ToArray());
        int.TryParse(stringUnitValue, out int unitValue);

        string fromUnit = new(_fromUnit.Where(Char.IsLetter).ToArray());
        var siPrefix = _siComparer.GetPrefix(fromUnit);
        string toUnit = new(_toUnit.Where(Char.IsLetter).ToArray());

        Value = unitValue;
        UnitPrefix = siPrefix;
        FromUnit = _siComparer.RemovePrefix(fromUnit, siPrefix?.PrefixName);
        ToUnit = toUnit;
    }
}
