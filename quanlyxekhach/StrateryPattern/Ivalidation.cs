using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace quanlyxekhach.StrateryPattern
{
    public enum ValidationType
    {
        INTERGER,
        FLOAT,
        STRING,
        EMAIL,
        DATE,
        PHONE
    }

    public interface Ivalidation
    {
        bool valid(string text);
    }

    public class IntValid : Ivalidation
    {
        public bool valid(string text)
        {
            return int.TryParse(text, out int a);
        }
    }

    public class FloatValid : Ivalidation
    {
        public bool valid(string text)
        {
            return float.TryParse(text, out float a);
        }
    }

    public class EmailValid : Ivalidation
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

    public class PhoneValid : Ivalidation
    {
        public bool valid(string text)
        {
            string regex = @"(84|0[3|5|7|8|9])+([0-9]{8})\b";

            if (!Regex.IsMatch(text, regex))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public class DatetimeValid : Ivalidation
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