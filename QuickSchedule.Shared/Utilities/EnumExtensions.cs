﻿using QuickSchedule.Shared.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSchedule.Shared.Utilities
{
    public static class EnumExtensions
    {
        public static string GetName(this Enum value)
        {
            var type = value.GetType();
            var memberInfo = type.GetMember(value.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(typeof(CountryFlagIcon), false);
            return (attributes.Length > 0) ? ((CountryFlagIcon)attributes[0]).Name : value.ToString();
        }

        public static string GetIcon(this Enum value)
        {
            var type = value.GetType();
            var memberInfo = type.GetMember(value.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(typeof(CountryFlagIcon), false);
            return (attributes.Length > 0) ? ((CountryFlagIcon)attributes[0]).IconBase64 : string.Empty;
        }

        public static int GetValue(this Enum value)
        {
            return Convert.ToInt32(value);
        }
    }
}
