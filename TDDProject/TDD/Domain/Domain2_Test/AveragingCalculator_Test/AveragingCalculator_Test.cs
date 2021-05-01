using Domain2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain2_Test.AveragingCalculator_Test
{
    public class AveragingCalculator_Test
    {
        private AveragingCalculator _averagingCalculator;
        private List<Measurement> _measurements;
        private Measurement _result;

        [SetUp]  //setup function run before each test method
        public void SetUpTest()
        {
            _averagingCalculator = new AveragingCalculator();
            _measurements = SetMeasurement.CreateMeasurementListOfSize(4);
            _result = _averagingCalculator.AverageMeasurement(_measurements);
        }

        private decimal AverageHigh(List<Measurement> measurements)
        {
            return measurements.Sum(m => m.HighValue) / measurements.Count;
        }
        private decimal AverageLow(List<Measurement> measurements)
        {
            return measurements.Sum(m => m.LowValue) / measurements.Count;
        }

        [Test]
        public void HighValueTest()
        {
            var expectedAverage = AverageHigh(_measurements);
            Assert.AreEqual(expectedAverage, _result.HighValue);
        }

        [Test]
        public void LowValueTest()
        {
            var expectedAverage = AverageLow(_measurements);
            Assert.AreEqual(expectedAverage, _result.LowValue);
        }

    }
}
