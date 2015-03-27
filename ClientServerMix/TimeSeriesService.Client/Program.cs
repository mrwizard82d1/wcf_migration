using System;
using System.Collections.Generic;
using TimeSeries;
using TimeSeriesService.Client.TimeSeriesReference;

namespace TimeSeriesService.Client
{
    class Program
    {
        static void Main()
        {
            var proxy = new TimeSeriesServiceClient();
            var oneDataPoint = new List<DataPoint>
            {
                new DataPoint()
            }.ToArray();
            var oneDataPointResult = proxy.New(oneDataPoint);
            Console.WriteLine("One data point: {0}", oneDataPointResult);

            var twoDataPoints = new List<DataPoint>
            {
                new DataPoint(),
                new DataPoint()
            }.ToArray();
            var twoDataPointsResult = proxy.New(twoDataPoints);
            Console.WriteLine("Two data points: {0}", twoDataPointsResult);

            var threeDataPoints = new List<DataPoint>
            {
                new DataPoint(),
                new DataPoint(),
                new DataPoint()
            }.ToArray();
            var threeDataPointsResult = proxy.New(threeDataPoints);
            Console.WriteLine("Three data points: {0}",
                threeDataPointsResult);

            Console.WriteLine();
            Console.WriteLine("--");
            Console.WriteLine();
            Console.WriteLine("Press <ENTER> to terminate client.");
            Console.ReadLine();
        }
    }
}
