using System.Collections.Generic;
using System.ServiceModel;
using TimeSeries;

namespace TimeSeriesService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITimeSeriesService" in both code and config file together.
    [ServiceContract(Namespace = "http://www.cjl-magistri.com")]
    public interface ITimeSeriesService
    {
        [OperationContract]
        TimeSeriesBase New(IEnumerable<IDataPoint> dataPoints);
    }
}
