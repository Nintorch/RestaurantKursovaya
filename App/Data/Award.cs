using System;
using System.Collections.Generic;

namespace App.Data
{
    public partial class Award
    {
        public int ID { get; set; }
        public int? EmployeeID { get; set; }
        public int? AmountInRubles { get; set; }
        public DateTime? AwardDate { get; set; }
        public string? Reason { get; set; }

        public virtual Employee? EmployeeNavigation { get; set; }
    }
}
