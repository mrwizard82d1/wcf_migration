using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TimeSeries
{
    [DataContract]
    class SetPointTimeSeries : TimeSeriesBase
    {
        // ReSharper disable once NotAccessedField.Local
        private IList<DataPoint> _settings;

        public SetPointTimeSeries(IList<DataPoint> dataPoints)
        {
            _settings = dataPoints;
        }
    }
}