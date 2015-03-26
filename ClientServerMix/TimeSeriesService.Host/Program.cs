using System;
using System.ServiceModel;

namespace TimeSeriesService.Host
{
    class Program
    {
        static void Main()
        {
            using (var host = new ServiceHost(typeof(TimeSeriesServiceImpl)))
            {
                host.Open();

                Console.WriteLine("Pres <ENTER> to terminate host.");
                Console.ReadLine();
            }
        }
    }
}
