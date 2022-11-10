namespace UnitConversion.Model;

public class MetricsType
{
    public MetricsType(Type type, List<MetricsSearchKeywords> unitMetrics)
    {
        TypeOfMetrics = type;
        MetricsSearchKeyWords = unitMetrics;
    }
    public Type TypeOfMetrics { get; set; }
    public List<MetricsSearchKeywords> MetricsSearchKeyWords { get; set; }
}