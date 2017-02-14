using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public static class Date
    {
        public static DateTime timeObject = DateTime.Now;
        private static string dateFormat = "dd/MM/yyyy";
        private static string timeFormat = "HH:mm:ss";

        public static string getDate()
        {
            return timeObject.ToString(dateFormat);
        }

        public static  string getTime()
        {
            return timeObject.ToString(timeFormat);
        }

    }
}
