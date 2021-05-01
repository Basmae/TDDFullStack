using Domain2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain2_Test
{
    [TestFixture]
    public class MyTestFixture
    {
        [Test]
        public void IsEqualResult()
        {
            var result = 2 + 2;
            Assert.AreEqual(4, result);
        }
        [Test]
        public void GroupingListOfOneByOne()
        {
            var measurements = CreateMeasurementListOfSize(1);
            var grouper = new SizeGrouper(1);
            var groupedResult = grouper.Group(measurements);
            Assert.AreEqual(1, groupedResult.Count);
        }
        [Test]
        public void GroupingListOfTwoByOne()
        {
            var measurements = CreateMeasurementListOfSize(2);
            var grouper = new SizeGrouper(1);
            var groupedResult = grouper.Group(measurements);
            Assert.AreEqual(2, groupedResult.Count);

        }

        [Test]
        public void GroupingListOfFourByTwo()
        {
            var measurements = CreateMeasurementListOfSize(4);
            var grouper = new SizeGrouper(2);
            var groupedResult = grouper.Group(measurements);
            Assert.AreEqual(2, groupedResult.Count);
        }
        private List<Measurement> CreateMeasurementListOfSize (int size)
        {
            var result = new List<Measurement>();
            for(int i=0;i<size;i++)
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
