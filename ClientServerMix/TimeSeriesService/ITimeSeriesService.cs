using System.Collections.Generic;
using System.ServiceModel;
using TimeSeries;

namespace TimeSeriesService
{
    [ServiceContract(Namespace = "http://www.cjl-magistri.com")]
    public interface ITimeSeriesService
    {
        [OperationContract]
        TimeSeriesBase New(IList<IDataPoint> dataPoints);
    }
}
