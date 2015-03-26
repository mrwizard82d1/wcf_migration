using System.Collections.Generic;
using TimeSeries;

namespace TimeSeriesService
{
    public class TimeSeriesServiceImpl : ITimeSeriesService
    {
        public TimeSeriesBase New(IList<IDataPoint> dataPoints)
        {
            return ((TimeSeriesBase) TimeSeriesBase.Create(dataPoints));
        }
    }
}
