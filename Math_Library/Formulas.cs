using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Library
{
    public class Formulas
    {


        // Сюда надо передавать кол-во рублей в час, кол-во рабочих часов в день, кол-во рабочих дней в неделю
        public static float Base_salary(float roub_per_hour, float hours_per_day, float work_days_in_week)
        {
            if ((hours_per_day < 0) || (roub_per_hour < 0 ) || (work_days_in_week < 0)){
                throw new Exception();
            }

            return roub_per_hour * hours_per_day * work_days_in_week * 4;

        }

        // Сюда надо передавать дату начала и окончания болезни, кол-во рабочих часов в неделю, зарплату за час

        public static float Sick_tax(DateTime start, DateTime finish,  float hours_per_day, float roub_per_hour)
        {

            if ((hours_per_day < 0) || (roub_per_hour<0))
            {
                throw new Exception();
            }



            var dif = (finish - start).Days;
            var mis_hours = dif * hours_per_day;

            return mis_hours * roub_per_hour - ((mis_hours * 19242) / (hours_per_day * 7 * 4));

        }


        // Сюда надо передавать количество сверхурочных часов и зарплату за час
        public static float Overtime_salary(float hours, float overtime_salary)
        {
            if ((hours < 0) || (overtime_salary < 0))
            {
                throw new Exception();
            }



            return hours * overtime_salary;

        }


        // Вместо IClass заведи пожалуйста интерфейс класса ентити фреймворк, а поле Value можешь исправить на поле с премиями
        public static float Premiy(ICollection<IClass> arr)
        {

            float sum = 0;

            //if (arr.IsEmpty())
            //{
            //    return sum
            //}

            foreach (var item in arr)
            {
                sum += Convert.ToInt64(item.Value);
            }
            return sum;
        }
        // Вместо IClass заведи пожалуйста интерфейс класса ентити фреймворк
        public static float Taxes(ICollection<IClass> arr)
        {

            float sum = 0;


            foreach (var item in arr)
            {
                sum += Convert.ToInt64(item.Value);
            }
            return sum;
        }

        //Здесь я пока не понял как задать данные для необязательных параметров
        public static float Salary(float roub_per_hour, float hours_per_day, float work_days_in_week, float overtime_salary,  DateTime start, DateTime finish, ICollection arr1, ICollection arr2, float hours = 0)
        {
            return Base_salary(roub_per_hour, hours_per_day, work_days_in_week) - Sick_tax(start, finish, hours_per_day, roub_per_hour) + Overtime_salary(hours, overtime_salary) + Premiy(arr1) - Taxes(arr2);
        }

    }
}
