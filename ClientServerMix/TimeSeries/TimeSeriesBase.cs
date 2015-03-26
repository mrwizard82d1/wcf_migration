using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace TimeSeries
{
    [DataContract]
    public class TimeSeriesBase : ITimeSeries
    {
        public static ITimeSeries Create(IList<IDataPoint> dataPoints)
        {
            // A stupid implementation
            switch (dataPoints.Count())
            {
                case 1:
                    return new IrregularTimeSeries(dataPoints);

                case 2:
                    return new RegularTimeSeries(dataPoints);

                case 3:
                    return new SetPointTimeSeries(dataPoints);
            }
            return null;
        }
    }
}