using System;
using System.Collections.Generic;

namespace App.Data
{
    public partial class OvertimePeriod
    {
        public int ID { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime? Date { get; set; }
        public short? OvertimeHoursCount { get; set; }

        public virtual Employee? EmployeeNavigation { get; set; }
    }
}
