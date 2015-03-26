using System.Collections.Generic;

namespace TimeSeries
{
    class RegularTimeSeries : TimeSeriesBase
    {
        // ReSharper disable once NotAccessedField.Local
        private IList<IDataPoint> _points;

        public RegularTimeSeries(IList<IDataPoint> dataPoints)
        {
            _points = dataPoints;
        }
    }
}