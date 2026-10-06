using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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

        public static string ToLatinDigits(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            var sb = new StringBuilder(s.Length);
            foreach (char c in s)
            {
                if (c >= '\u06F0' && c <= '\u06F9') sb.Append((char)('0' + (c - '\u06F0')));
                else if (c >= '\u0660' && c <= '\u0669') sb.Append((char)('0' + (c - '\u0660')));
                else sb.Append(c);
            }
            return sb.ToString();
        }


        public static bool TryParseShamsi(string text, out DateTime result)
        {
            result = DateTime.MinValue;
            if (string.IsNullOrWhiteSpace(text)) return false;


            string[] parts = ToLatinDigits(text.Trim()).Split('/');
            if (parts.Length != 3) return false;


            int y, m, d;
            if (!int.TryParse(parts[0], out y) ||
                !int.TryParse(parts[1], out m) ||
                !int.TryParse(parts[2], out d)) return false;


            try
            {
                result = pc.ToDateTime(y, m, d, 0, 0, 0, 0);
                return true;
            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }
        }


        public static DateTime ShamsiMonthStart(DateTime d)
        {
            return pc.ToDateTime(pc.GetYear(d), pc.GetMonth(d), 1, 0, 0, 0, 0);
        }


        public static void GridCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null || e.Value == DBNull.Value) return;


            if (e.Value is DateTime)
            {
                DateTime dt = (DateTime)e.Value;
                string s = ToShamsi(dt);


                if (dt.TimeOfDay != TimeSpan.Zero)
                    s += " - " + dt.ToString("HH:mm");


                e.Value = s;
                e.FormattingApplied = true;
            }
        }

    }
}
