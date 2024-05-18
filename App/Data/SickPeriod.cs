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

        public bool ContainsOrTouches(DateTime dateStart, DateTime dateEnd) =>
            (dateStart <= DateStart && dateEnd >= DateStart) || // Начало больничного входит в период 
            (dateStart <= DateEnd && dateEnd >= DateEnd) ||     // Конец больничного входит в период
            (dateStart >= DateStart && dateEnd <= DateEnd) ||   // Период входит в больничный период
            (dateStart <= DateStart && dateEnd >= DateEnd);     // Больничный период входит в период
    }
}
