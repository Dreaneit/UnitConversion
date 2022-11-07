namespace UnitConversion.Model;
public class SIPrefix
{
    public SIPrefix(string prefixName, decimal multiplier)
    {
        PrefixName = prefixName;
        Multiplier = multiplier;
    }

    public string PrefixName { get; set; }
    public decimal Multiplier { get; set; }
}
