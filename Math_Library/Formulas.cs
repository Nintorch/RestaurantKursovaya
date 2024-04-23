using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Library
{
    public class Formulas
    {
        public static float Base_salary(float roub_per_hour, float hours_per_day, float work_days_in_week)
        {
            if ((hours_per_day < 0) || (roub_per_hour < 0 ) || (work_days_in_week < 0)){
                throw new Exception();
            }

            return roub_per_hour * hours_per_day * work_days_in_week * 4;

        }


        public static float Sick_tax(DateTime start, DateTime finish,  float hours_per_day, float roub_per_hour)
        {

            if ((hours_per_day < 0) || (roub_per_hour<0))
            {
                throw new Exception();
            }



            var dif = (finish - start).Days + 1;
            var mis_hours = dif * hours_per_day;

            return mis_hours * roub_per_hour - ((mis_hours * 19242) / (hours_per_day * 7 * 4));

        }

        public static float Overtime_salary(float hours, float roubles_per_hour)
        {
            if ((hours < 0) || (roubles_per_hour < 0))
            {
                throw new Exception();
            }



            return hours * roubles_per_hour;

        }





    }
}
