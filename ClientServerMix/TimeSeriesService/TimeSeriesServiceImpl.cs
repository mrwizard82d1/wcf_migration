﻿using System;
using System.Collections.Generic;
using TimeSeries;

namespace TimeSeriesService
{
    public class TimeSeriesServiceImpl : ITimeSeriesService
    {
        public TimeSeriesBase New(IEnumerable<IDataPoint> dataPoints)
        {
            return ((TimeSeriesBase) TimeSeriesBase.Create(dataPoints));
        }
    }
}
