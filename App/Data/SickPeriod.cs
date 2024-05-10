using System;
using System.Collections.Generic;

namespace App.Data
{
    public partial class SickPeriod
    {
        public int ID { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public string? Reason { get; set; }
    }
}
