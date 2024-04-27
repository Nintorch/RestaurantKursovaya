using Math_Library;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Employee employee = new Employee()
            {
                RublesPerHour = 210,
                WorkHoursPerDay = 5,
                WorkDaysPerWeek = 5,
            };

            float premiiMonth = 500;
            float finesMonth = 500;

            List<SickPeriod> sickPeriods = new List<SickPeriod>
            {
                new SickPeriod(new DateTime(2024, 4, 5), new DateTime(2024, 4, 7)),
                new SickPeriod(new DateTime(2024, 4, 10), new DateTime(2024, 4, 10)),
            };

            float overtimeHours = 1;
            Assert.IsTrue(Math.Abs(Formulas.Salary(employee, premiiMonth, finesMonth, sickPeriods, overtimeHours) - 20858.4f) < 1.0f);
        }

        [TestMethod]
        public void InvalidData1()
        {
            Employee employee = new Employee()
            {
                RublesPerHour = -210,
                WorkHoursPerDay = 5,
                WorkDaysPerWeek = 5,
            };

            float premiiMonth = 500;
            float finesMonth = 500;

            List<SickPeriod> sickPeriods = new List<SickPeriod>
            {
                new SickPeriod(new DateTime(2024, 4, 5), new DateTime(2024, 4, 7)),
                new SickPeriod(new DateTime(2024, 4, 10), new DateTime(2024, 4, 10)),
            };

            float overtimeHours = 1;
            Assert.ThrowsException<Exception>(() => Formulas.Salary(employee, premiiMonth, finesMonth, sickPeriods, overtimeHours));
        }

        [TestMethod]
        public void InvalidData2()
        {
            Employee employee = new Employee()
            {
                RublesPerHour = 210,
                WorkHoursPerDay = -5,
                WorkDaysPerWeek = -5,
            };

            float premiiMonth = 500;
            float finesMonth = 500;

            List<SickPeriod> sickPeriods = new List<SickPeriod>
            {
                new SickPeriod(new DateTime(2024, 4, 5), new DateTime(2024, 4, 7)),
                new SickPeriod(new DateTime(2024, 4, 10), new DateTime(2024, 4, 10)),
            };

            float overtimeHours = 1;
            Assert.ThrowsException<Exception>(() => Formulas.Salary(employee, premiiMonth, finesMonth, sickPeriods, overtimeHours));
        }

        [TestMethod]
        public void InvalidData3()
        {
            Employee employee = new Employee()
            {
                RublesPerHour = 210,
                WorkHoursPerDay = 5,
                WorkDaysPerWeek = 5,
            };

            float premiiMonth = -500;
            float finesMonth = -500;

            List<SickPeriod> sickPeriods = new List<SickPeriod>
            {
                new SickPeriod(new DateTime(2024, 4, 5), new DateTime(2024, 4, 7)),
                new SickPeriod(new DateTime(2024, 4, 10), new DateTime(2024, 4, 10)),
            };

            float overtimeHours = 1;
            Assert.ThrowsException<Exception>(() => Formulas.Salary(employee, premiiMonth, finesMonth, sickPeriods, overtimeHours));
        }

        [TestMethod]
        public void InvalidData4()
        {
            Employee employee = new Employee()
            {
                RublesPerHour = 210,
                WorkHoursPerDay = 5,
                WorkDaysPerWeek = 5,
            };

            float premiiMonth = 500;
            float finesMonth = 500;

            List<SickPeriod> sickPeriods = new List<SickPeriod>
            {
                new SickPeriod(new DateTime(2024, 4, 5), new DateTime(2024, 4, 7)),
                new SickPeriod(new DateTime(2024, 4, 10), new DateTime(2024, 4, 10)),
            };

            float overtimeHours = -1;
            Assert.ThrowsException<Exception>(() => Formulas.Salary(employee, premiiMonth, finesMonth, sickPeriods, overtimeHours));
        }
    }
}