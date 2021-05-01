using Domain2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain2_Test.SadPath
{
    public class MeasurementsAreNull
    {
        private AveragingCalculator _averagingCalculator;

        [SetUp]  //setup function run before each test method
        public void SetUpTest()
        {
            _averagingCalculator = new AveragingCalculator();
        }

        [Test]
        public void TestMeasurementAreNull()
        {
            Exception ex = null;
            try
            {
                _averagingCalculator.AverageMeasurement(null);
            }
            catch(Exception e)
            {
                ex = e;
            }
            Assert.IsNotNull(ex);
        }
    }
}
