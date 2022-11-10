using UnitConversion.Model;

namespace UnitConversion.Interfaces;
public interface ISIPrefixes
{
    SIPrefix? GetPrefix(string unit);
    string? RemovePrefix(string unit, string? prefix);
}
