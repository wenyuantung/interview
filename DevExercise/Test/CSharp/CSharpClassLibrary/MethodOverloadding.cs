using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClassLibrary
{
    public class MethodOverloadding
    {
        public static string GetValue(int value)
        {
            return value.ToString();
        }

        public static string GetValue(double value)
        {
            return string.Format("{0: F2}", value);
        }

        public static string GetValue(string value)
        {
            return value;
        }

        public static string GetValue(object value)
        {
            return typeof(object).ToString();
        }
    }
}
