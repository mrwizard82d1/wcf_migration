using System.Collections.Generic;

namespace TimeSeries
{
    internal class IrregularTimeSeries : TimeSeriesBase
    {
        // ReSharper disable once NotAccessedField.Local
        private IEnumerable<IDataPoint> _dataPoints;

        public IrregularTimeSeries(IEnumerable<IDataPoint> dataPoints)
        {
            _dataPoints = dataPoints;
        }
    }
}