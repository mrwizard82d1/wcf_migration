using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TimeSeries
{
    [DataContract]
    internal class IrregularTimeSeries : TimeSeriesBase
    {
        // ReSharper disable once NotAccessedField.Local
        private IEnumerable<DataPoint> _dataPoints;

        public IrregularTimeSeries(IEnumerable<DataPoint> dataPoints)
        {
            _dataPoints = dataPoints;
        }
    }
}