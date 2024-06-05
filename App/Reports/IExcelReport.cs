using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Reports
{
    public interface IExcelReport
    {
        void WriteToFile(string filename);
    }
}
