using Domain2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain2_Test.AveragingCalculator_Test
{
    [TestFixture(20.0, 10.0 ,15.0 ,2.0 ,4.0 ,3.0)]
    public class Averaging_Several_Numbers
    {
        private readonly decimal _highValue1;
        private readonly decimal _lowValue1;
        private readonly decimal _highValue2;
        private readonly decimal _lowValue2;
        private readonly decimal _highValueAvg;
        private readonly decimal _lowValueAvg;

        private AveragingCalculator _averagingCalculator;
        private List<Measurement> _measurements;
        private Measurement _result;

        public Averaging_Several_Numbers(decimal high1, decimal high2, decimal highAvg,
                                         decimal low1, decimal low2, decimal lowAvg)
        {
            _highValue1 = high1;
            _highValue2 = high2;
            _highValueAvg = highAvg;
            _lowValue1 = low1;
            _lowValue2 = low2;
            _lowValueAvg = lowAvg;

        }
        private void GetMeasurements()
        {
            _measurements.Add(new Measurement()
            {
                HighValue = _highValue1,
                LowValue = _lowValue1
            });
            _measurements.Add(new Measurement()
            {
                HighValue = _highValue2,
                LowValue = _lowValue2
            });
            _result = new Measurement()
            {
                HighValue = _highValueAvg,
                LowValue = _lowValueAvg
            };
        }
        [SetUp]  //setup function run before each test method
        public void SetUpTest()
        {
            GetMeasurements();
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
