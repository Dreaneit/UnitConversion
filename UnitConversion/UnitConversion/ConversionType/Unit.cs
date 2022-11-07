using static UnitConversion.ConversionType.Length;

namespace UnitConversion.ConversionType;
public class Unit
{
    protected readonly string[]? _searchKeyWords;

    public Unit(string[]? searchKeyWords)
    {
        _searchKeyWords = searchKeyWords;
    }
}
