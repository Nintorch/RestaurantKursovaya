using System;
using System.Collections.Generic;

namespace App.Data
{
    public partial class Employee
    {
        public Employee()
        {
            Awards = new HashSet<Award>();
            OvertimePeriods = new HashSet<OvertimePeriod>();
            Fines = new HashSet<Fine>();
        }

        public int ID { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Role { get; set; }
        public int? WorkHoursPerDay { get; set; }
        public int? WorkDaysPerWeek { get; set; }
        public DateTime? RoleWorkStartDate { get; set; }
        public int? BaseSalaryPerHourInRubles { get; set; }

        public virtual ICollection<Award> Awards { get; set; }
        public virtual ICollection<OvertimePeriod> OvertimePeriods { get; set; }
        public virtual ICollection<Fine> Fines { get; set; }
    }
}
