using System;
using System.Collections.Generic;

namespace App.Data
{
    public partial class Fine
    {
        public int ID { get; set; }
        public int? EmployeeID { get; set; }
        public int? Amount { get; set; }
        public DateTime? Date { get; set; }
        public string? Reason { get; set; }
        public int? GiverID { get; set; }

        public virtual Employee? EmployeeNavigation { get; set; }
    }
}
