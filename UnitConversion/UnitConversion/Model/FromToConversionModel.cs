using UnitConversion.Interfaces;

namespace UnitConversion.Model;
public class FromToConversionModel
{
    public IUnit? ConversionInstance { get; set; }
    public UnitMetrics From { get; set; }
    public UnitMetrics To { get; set; }
}
