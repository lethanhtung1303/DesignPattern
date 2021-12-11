using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace quanlyxekhach.StrateryPattern
{
    public enum ValidationType
    {
        INTERGER,
        FLOAT,
        STRING,
        EMAIL,
        DATE
    }

    internal interface Ivalidation
    {
        bool valid(string text);
    }

    internal class IntValid : Ivalidation
    {
        public bool valid(string text)
        {
            return int.TryParse(text, out int a);
        }
    }

    internal class FloatValid : Ivalidation
    {
        public bool valid(string text)
        {
            return float.TryParse(text, out float a);
        }
    }

    internal class EmailValid : Ivalidation
    {
        public bool valid(string text)
        {
            string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            //check first string
            if (Regex.IsMatch(text, pattern))
            {
                //if email is valid
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    internal class DatetimeValid : Ivalidation
    {
        public bool valid(string text)
        {
            DateTime d;

            bool chValidity = DateTime.TryParseExact(
            text,
            "dd/MM/yyyy",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out d);
            return chValidity;
        }
    }

    public class StringValid : Ivalidation
    {
        public bool valid(string text)
        {
            if (!int.TryParse(text, out int a) || !float.TryParse(text, out float b))
                return true;
            return false;
        }
    }
}