using UnitConversion.Interfaces;
using UnitConversion.Model;
using static UnitConversion.ConversionType.Length;

namespace UnitConversion.ConversionType;
public class Unit : IBaseUnit
{
    protected List<MetricsType>? _metricsType;
    private IEnumerable<MetricsSearchKeywords>? _searchKeywords;

    public Unit() { }

    public Unit(List<MetricsType> metricsTypes)
    {
        _metricsType = metricsTypes;
        _searchKeywords = metricsTypes.SelectMany(x => x.MetricsSearchKeyWords);
    }

    public FromToConversionModel? GetConversionUnits(string? fromUnit, string? toUnit)
    {
        var fromUnitType = _searchKeywords?.Select(x => x).Where(x => x.KeywordsForUnitMetric.Contains(fromUnit)).FirstOrDefault()?.UnitMetricType;
        var toUnitType = _searchKeywords?.Select(x => x).Where(x => x.KeywordsForUnitMetric.Contains(toUnit)).FirstOrDefault()?.UnitMetricType;

        var typeOfInstance = _metricsType?.FirstOrDefault(x => x.MetricsSearchKeyWords.Any(k => k.KeywordsForUnitMetric.Contains(toUnit) || k.KeywordsForUnitMetric.Contains(fromUnit)))?.TypeOfMetrics;

        if (fromUnitType != null && toUnitType != null)
            return new FromToConversionModel
            {
                ConversionInstance = (IUnit)Activator.CreateInstance(typeOfInstance),
                From = (UnitMetrics)fromUnitType,
                To = (UnitMetrics)toUnitType
            };

        return null;
    }
}
