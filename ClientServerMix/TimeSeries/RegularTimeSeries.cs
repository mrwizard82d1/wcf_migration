using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TimeSeries
{
    [DataContract]
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