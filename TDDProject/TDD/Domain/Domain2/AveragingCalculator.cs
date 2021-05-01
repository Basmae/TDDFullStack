using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain2
{
    public class AveragingCalculator
    {
        public Measurement AverageMeasurement(List<Measurement> measurements)
        {
            Measurement result = new Measurement();
            result.HighValue = (measurements.Sum(m => m.HighValue)) / measurements.Count;
            result.LowValue = (measurements.Sum(m => m.LowValue)) / measurements.Count;
            return result;
        }
    }
}
