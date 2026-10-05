using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace msqPRJ.forms
{
    public static class DateHelper
    {
        private static readonly PersianCalendar pc = new PersianCalendar();

        public static string ToShamsi(DateTime d)
        {
            return string.Format("{0:0000}/{1:00}/{2:00}",
                pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d));
        }
    }
}
