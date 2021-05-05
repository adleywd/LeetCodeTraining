using System;

namespace LeetCode
{
    public class DayOfTheYear1154
    {
        // YYYY-MM-DD
        public int DayOfTheYear(string date)
        {
            var totalDays = 0;
            var year = int.Parse(date.Substring(0,4));
            var month = int.Parse(date.Substring(5,2));
            var day = int.Parse(date.Substring(8,2));

            for(int i=1; i < month; i++)
            {
                var dayInThisMonth = DateTime.DaysInMonth(year, i);
                totalDays += dayInThisMonth;
            }

            totalDays += day;

            return totalDays;
        }
    }
}