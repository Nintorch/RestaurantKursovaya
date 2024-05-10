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

        public ICollection<SickPeriod> SickPeriods
        {
            get => new RestaurantContext().SickPeriods.Where(x => x.EmployeeID == ID).ToList();
        }

        public string GetFullName() => string.Join(' ', new List<string> { LastName, FirstName, MiddleName }.Where(x => x != null));

        public void Delete()
        {
            RestaurantContext context = new();

            foreach (var item in Awards)
                context.Awards.Remove(item);

            foreach (var item in OvertimePeriods)
                context.OvertimePeriods.Remove(item);

            foreach (var item in Fines)
                context.Fines.Remove(item);

            foreach (var item in SickPeriods)
                context.SickPeriods.Remove(item);

            context.SaveChanges();
        }
    }
}
