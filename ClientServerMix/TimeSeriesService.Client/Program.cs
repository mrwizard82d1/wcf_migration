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
            Console.WriteLine("Irregular: {0}", oneDataPointResult);

            Console.WriteLine("Press <ENTER> to terminate client.");
            Console.ReadLine();
        }
    }
}
