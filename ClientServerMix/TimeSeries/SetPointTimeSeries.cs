using System.Collections.Generic;

namespace TimeSeries
{
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