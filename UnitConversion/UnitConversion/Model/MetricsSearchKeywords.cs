namespace UnitConversion.Model;
public class MetricsSearchKeywords
{
    private readonly UnitMetrics _unitMetricType;
    private readonly string[] _keywordsForUnitMetric;

    public MetricsSearchKeywords(UnitMetrics unitMetricsType, string[] keywordsForUnitMetric)
    {
        _unitMetricType = unitMetricsType;
        _keywordsForUnitMetric = keywordsForUnitMetric;
    }

    public UnitMetrics UnitMetricType { get { return _unitMetricType;  } set { } }
    public string[] KeywordsForUnitMetric { get { return _keywordsForUnitMetric; } set { } }
}
