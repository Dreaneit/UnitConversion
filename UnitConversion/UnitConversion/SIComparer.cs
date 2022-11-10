using UnitConversion.Interfaces;
using UnitConversion.Model;

namespace UnitConversion;
public class SIPrefixes : ISIPrefixes
{
    private readonly List<SIPrefix> _siPrefixes;
    public SIPrefixes()
    {
        _siPrefixes = new List<SIPrefix>()
        {
            new SIPrefix("yotta",    24),
            new SIPrefix("zetta",    21),
            new SIPrefix("exa",      18),
            new SIPrefix("peta",     15),
            new SIPrefix("tera",     12),
            new SIPrefix("giga",     9),
            new SIPrefix("mega",     6),
            new SIPrefix("kilo",     3),
            new SIPrefix("hecto",    2),
            new SIPrefix("deca",     1),
            new SIPrefix("deci",     -1),
            new SIPrefix("centi",    -2),
            new SIPrefix("milli",    -3),
            new SIPrefix("micro",    -6),
            new SIPrefix("nano",     -9),
            new SIPrefix("pico",     -12),
            new SIPrefix("femto",    -15),
            new SIPrefix("atto",     -18),
            new SIPrefix("zepto",    -21),
            new SIPrefix("yocto",    -24),
        };
    }

    public SIPrefix? GetPrefix(string unit) => _siPrefixes.FirstOrDefault(x => unit.Contains(x.PrefixName));
    public string? RemovePrefix(string unit, string? prefix)
    {
        if (prefix == null)
            return unit;

        return unit.Replace(prefix, string.Empty);
    }
}
