#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion Using Directives

namespace Core
{
    public struct DateRange
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public static DateTime MaxDate
        {
            get
            {
                return new DateTime(2050, 1, 1);
            }
        }

        public static DateRange Today
        {
            get
            {
                return FromInDays(DateTime.Now, 1);
            }
        }

        public static DateRange Week
        {
            get
            {
                return FromInDays(DateTime.Now, 7);
            }
        }

        public static DateRange Month
        {
            get
            {
                return FromInMonths(DateTime.Now, 1);
            }
        }

        public static DateRange FromToday
        {
            get
            {
                return new DateRange { StartDate = DateTime.Now.Date, EndDate = MaxDate };
            }
        }

        public static DateRange FromInDays(DateTime startDate, int rangeInDays)
        {
            return new DateRange
            {
                StartDate = startDate.Date,
                EndDate = startDate.Date.AddDays(rangeInDays)
            };
        }

        public static DateRange FromInMonths(DateTime startDate, int rangeInMonths)
        {
            return new DateRange
            {
                StartDate = startDate.Date,
                EndDate = startDate.Date.AddMonths(rangeInMonths)
            };
        }
    }
}
