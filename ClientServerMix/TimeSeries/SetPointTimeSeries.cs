using System.Collections.Generic;

namespace TimeSeries
{
    class SetPointTimeSeries : TimeSeriesBase
    {
        // ReSharper disable once NotAccessedField.Local
        private IList<IDataPoint> _settings;

        public SetPointTimeSeries(IList<IDataPoint> dataPoints)
        {
            _settings = dataPoints;
        }
    }
}