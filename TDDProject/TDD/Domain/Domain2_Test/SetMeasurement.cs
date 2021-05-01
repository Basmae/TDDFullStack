using Domain2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain2_Test
{
    public static class SetMeasurement
    {
        public static List<Measurement> CreateMeasurementListOfSize(int size)
        {
            var result = new List<Measurement>();
            for (int i = 0; i < size; i++)
            {
                result.Add(new Measurement()
                {
                    LowValue = 1,
                    HighValue = 10
                });
            }
            return result;
        }
    }
}
