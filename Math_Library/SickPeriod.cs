using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Library
{
    public class SickPeriod
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        public SickPeriod(DateTime start, DateTime finish)
        {
            Start = start;
            Finish = finish;
        }
    }
}
