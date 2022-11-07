using UnitConversion.Model;

namespace UnitConversion;
public interface ISIComparer
{
    int GetValueOfNumberAndPrefixSI(int value, string? unit);
    SIPrefix GetPrefix(string unit);
    string? RemovePrefix(string unit, string? prefix);
}
