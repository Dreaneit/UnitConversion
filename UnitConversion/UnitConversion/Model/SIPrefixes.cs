namespace UnitConversion.Model;
public class SIPrefix
{
    public SIPrefix(string prefixName, double multiplier)
    {
        PrefixName = prefixName;
        Multiplier = (decimal)Math.Pow(10, multiplier);
    }

    public string PrefixName { get; set; }
    public decimal Multiplier { get; set; }
}
