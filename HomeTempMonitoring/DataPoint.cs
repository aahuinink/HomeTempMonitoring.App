using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTempMonitoring
{
    public class DataPoint
    {
        private double _xVal;
        private double _yVal;

        public DataPoint(double xVal, double yVal)
        {
            XVal = xVal;
            YVal = yVal;
        }

        public double XVal { get => _xVal; set => _xVal = value; }
        public double YVal { get => _yVal; set => _yVal = value; }
    }
}
