using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data = App.Data;
using Math = Math_Library;

namespace TestProject1
{
    [TestClass]
    public class SickPeriodsTests
    {
        readonly DateTime monthStart = new(2024, 4, 1);
        readonly DateTime monthEnd = new(2024, 4, 30);

        private void DataSickPeriodTest(DateTime dateStart, DateTime dateEnd, bool intendedResult = true)
        {
            var sickPeriod = new Data.SickPeriod()
            {
                DateStart = dateStart,
                DateEnd = dateEnd,
            };
            Assert.AreEqual(sickPeriod.ContainsOrTouches(monthStart, monthEnd), intendedResult);
        }

        [TestMethod]
        public void PeriodContainsSickPeriod()
        {
            DataSickPeriodTest(new DateTime(2024, 4, 5), new DateTime(2024, 4, 7));
        }

        [TestMethod]
        public void SickPeriodContainsPeriod()
        {
            DataSickPeriodTest(new DateTime(2024, 3, 25), new DateTime(2024, 5, 5));
        }


        [TestMethod]
        public void SickPeriodTouchesPeriodStart()
        {
            DataSickPeriodTest(new DateTime(2024, 3, 25), new DateTime(2024, 4, 5));
        }

        [TestMethod]
        public void SickPeriodTouchesPeriodEnd()
        {
            DataSickPeriodTest(new DateTime(2024, 4, 25), new DateTime(2024, 5, 5));
        }

        [TestMethod]
        public void DoesntContainOrTouch()
        {
            DataSickPeriodTest(new DateTime(2024, 5, 5), new DateTime(2024, 5, 7), intendedResult: false);
        }

        private void AdjustSickPeriodTest(DateTime dateStart, DateTime dateEnd, int dayCount)
        {
            // Такие периоды хранятся в базе данных
            var sickPeriod = new Data.SickPeriod()
            {
                DateStart = dateStart,
                DateEnd = dateEnd,
            };
            // Подправляем период под длину месяца
            var adjustedSickPeriod = App.CalculateSalaryForm.AdjustSickPeriod(sickPeriod, monthStart, monthEnd);
            // Находим длину полученного периода
            var dif = Math.Formulas.SickPeriodLength(adjustedSickPeriod);

            Assert.AreEqual(dayCount, dif);
        }

        [TestMethod]
        public void AdjustPeriodContainsSickPeriod()
        {
            AdjustSickPeriodTest(new DateTime(2024, 4, 5), new DateTime(2024, 4, 7), 3);
        }

        [TestMethod]
        public void AdjustSickPeriodContainsPeriod()
        {
            AdjustSickPeriodTest(new DateTime(2024, 3, 25), new DateTime(2024, 5, 5), 30);
        }

        [TestMethod]
        public void AdjustSickPeriodTouchesPeriodStart()
        {
            // Должны быть дни 01 02 03 04 05
            AdjustSickPeriodTest(new DateTime(2024, 3, 20), new DateTime(2024, 4, 5), 5);
        }

        [TestMethod]
        public void AdjustSickPeriodTouchesPeriodEnd()
        {
            // В начале периода 26 и количество дней 5, так как 26 27 28 29 30
            AdjustSickPeriodTest(new DateTime(2024, 4, 26), new DateTime(2024, 5, 5), 5);
        }
    }
}
