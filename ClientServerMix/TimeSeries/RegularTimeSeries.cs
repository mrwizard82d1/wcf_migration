using System.Collections.Generic;

namespace TimeSeries
{
    class RegularTimeSeries : TimeSeriesBase
    {
        // ReSharper disable once NotAccessedField.Local
        private IList<DataPoint> _points;

        public RegularTimeSeries(IList<DataPoint> dataPoints)
        {
            _points = dataPoints;
        }
    }
}