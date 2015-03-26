using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace TimeSeries
{
    [DataContract]
    public class TimeSeriesBase : ITimeSeries
    {
        public static ITimeSeries Create(IEnumerable<IDataPoint> dataPoints)
        {
            // A stupid implementation
            switch (dataPoints.Count())
            {
                case 1:
                    return new IrregularTimeSeries(dataPoints);
            }
            return null;
        }
    }
}