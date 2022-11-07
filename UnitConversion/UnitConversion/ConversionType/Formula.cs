using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConversion.Model;

namespace UnitConversion.ConversionType;
public class Formula
{
    public Formula()
    {

    }
    public UnitMetrics From { get; set; }
    public UnitMetrics To { get; set; }
    public void UnitsFormula(int value) { }
}
