using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WWE.Lib.ExtentionMethod
{
    public static class DataTypeEx
    {
        public static int? ConvertToInt32(this string s)
        {
            try
            {
                return int.Parse(s);
            }
            catch
            {
                return null;
            }
        }
        public static string TrimAll(this string s)
        {
            return s.Replace("\n", "").Replace("\t", "").Replace("\r", "");
        }
        public static DateTime? ddMMyyyy(string s)
        {
            try
            {
                string[] spl = s.Split('/');
                int day = Convert.ToInt32(spl[0]);
                int month = Convert.ToInt32(spl[1]);
                int year = Convert.ToInt32(spl[2]);
                return new DateTime(year, month, day);
            }
            catch
            {
                return null;
            }
        }
    }
}
