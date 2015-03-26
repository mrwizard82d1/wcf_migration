using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TimeSeries;

namespace TimeSeriesService.Tests
{
    [TestClass]
    public class TimeSeriesServiceImplTest
    {
        [TestMethod]
        public void New_OneDataPoint_ReturnsIrregularTimeSeries()
        {
            var oneDataPoint = new List<IDataPoint>
            {
                new Mock<IDataPoint>().Object
            };
            var cut = new TimeSeriesServiceImpl();

            var actualResult = cut.New(oneDataPoint);

            Assert.IsInstanceOfType(actualResult, typeof(IrregularTimeSeries));
        }

        [TestMethod]
        public void New_TwoDataPoints_ReturnsRegularTimeSeries()
        {
            var twoDataPoints = new List<IDataPoint>
            {
                new Mock<IDataPoint>().Object,
                new Mock<IDataPoint>().Object
            };
            var cut = new TimeSeriesServiceImpl();

            var actualResult = cut.New(twoDataPoints);

            Assert.IsInstanceOfType(actualResult, typeof(RegularTimeSeries));           
        }

        [TestMethod]
        public void New_ThreeDataPoints_ReturnsRegularTimeSeries()
        {
            var threeDataPoints = new List<IDataPoint>
            {
                new Mock<IDataPoint>().Object,
                new Mock<IDataPoint>().Object,
                new Mock<IDataPoint>().Object
            };
            var cut = new TimeSeriesServiceImpl();

            var actualResult = cut.New(threeDataPoints);

            Assert.IsInstanceOfType(actualResult, typeof(SetPointTimeSeries));
        }
    }
}
