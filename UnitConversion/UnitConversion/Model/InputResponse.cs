namespace UnitConversion.Model;

public class InputUnit
{
    public int Value { get; set; }
    public SIPrefix? UnitPrefix { get; set; }
    public string? FromUnit { get; set; }
    public string? ToUnit { get; set; }
}
